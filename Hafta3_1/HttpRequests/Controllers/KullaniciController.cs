using HttpRequests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpRequests.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Listele()
        {
            List<Kullanici> liste =  new HazirKullaniciListesi();
            return View(liste);
        }


        public ActionResult Detail(int id)
        {
            List<Kullanici> liste = new HazirKullaniciListesi();
            Kullanici kullanici = liste.Find(x=> x.Id == id);

            return View(kullanici);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Kullanici model)
        {
            if (ModelState.IsValid)
            {
                TempData["Mesaj"] = new TempDataDictionary {
                    { "durum", " alert alert-success" },
                    { "mesaj", model.Ad + "" + model.Soyad + " isimli kayıt eklendi." }
                };

                return RedirectToAction(nameof(Listele));
            }
            return View();
        }
    }
}