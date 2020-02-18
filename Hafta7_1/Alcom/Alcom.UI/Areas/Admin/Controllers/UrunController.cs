using Alcom.BLL;
using Alcom.MODEL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Areas.Admin.Controllers
{
    public class UrunController : Controller
    {
        // GET: Admin/Urun
        public ActionResult Ekle()
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                var bransList = repo.Listele(x => !x.SilindiMi);
                ViewBag.Kategoriler = new SelectList(bransList, "Id", "Adi");
            }
            using (MarkaBilgileriRepository repo = new MarkaBilgileriRepository())
            {
                var markaList = repo.Listele(x => !x.SilindiMi);
                ViewBag.Markalar = new SelectList(markaList, "Id", "Ad");
            }
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Urun model, HttpPostedFileBase[] Medyalar)
        {
            try
            {
                model.KayitTarihi = DateTime.Now;
                using (UrunRepository repo = new UrunRepository())
                {
                    bool durum = repo.Ekle(model);
                    TempData["Mesaj"] = durum ? new TempDataDictionary { { "class", "alert alert-success" }, { "mesaj", "Kayıt eklendi." } } : new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Kayıt eklenemedi." } };

                }
                if (Medyalar.Length > 0)
                {
                    foreach (var item in Medyalar)
                    {
                        var uzanti = item.FileName.Split('.')[1];
                        var filePath=  Server.MapPath("/Areas/Admin/UrunMedyalari/");
                        var fileName = DateTime.Now.ToString().Replace(":", "").Replace(" ", "").Replace(".", "")+new Random().Next(0,9999);
                        var isim = Path.Combine(filePath, fileName + "." + uzanti);
                        item.SaveAs(isim);

                        using (MedyaRepository repo = new MedyaRepository())
                        {
                            repo.Ekle(new Medya { KayitTarihi = DateTime.Now, Url = fileName + "." + uzanti, UrunId = model.Id });
                        }
                    }
                }

                return RedirectToAction(nameof(Listele));

            }
            catch (Exception ex)
            {
                TempData["Mesaj"] =  new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", ex.Message } };

                return RedirectToAction(nameof(Ekle));
            }
        }

        public ActionResult Listele()
        {
            using (UrunRepository repo = new UrunRepository())
            {
               return View(repo.Listele(x => !x.SilindiMi));
            }
        }
    }
}