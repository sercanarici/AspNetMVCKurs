using Alcom.BLL;
using Alcom.MODEL;
using Alcom.UI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Admin/Kategori

        //[LoginFilter]
        [HttpGet]
        public ActionResult Ekle()
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                var bransList = repo.Listele(x => !x.SilindiMi);
                ViewBag.Kategoriler = new SelectList(bransList, "Id", "Adi");
                return View();
            }
           
        }

        [HttpPost]
        public ActionResult Ekle(Kategori model)
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
                model.KayitTarihi = DateTime.Now;
                bool durum = repo.Ekle(model);
                TempData["Mesaj"] = durum ? new TempDataDictionary { { "class", "alert alert-success" }, { "mesaj", "Kayıt eklendi." } } : new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Kayıt eklenemedi." } };
                return RedirectToAction(nameof(Ekle));
            }

        }

        public ActionResult Listele()
        {
            using (KategoriRepository repo = new KategoriRepository())
            {
              var sonuc =   repo.Listele(x => !x.SilindiMi); 
            return View(sonuc);
            }
        }
    }
}