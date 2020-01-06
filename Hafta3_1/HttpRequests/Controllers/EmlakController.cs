using HttpRequests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpRequests.Views
{
    public class EmlakController : Controller
    {
        // GET: Emlak
        public ActionResult Index()
        {
            var liste = new HazirEmlakListesi();

            return View(liste);
        }

        public ActionResult Detail(int id)
        {
            List<Emlak> liste = new HazirEmlakListesi();
            Emlak emlak = liste.Find(x => x.Id == id);

            return View(emlak);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Emlak model)
        {
            if (ModelState.IsValid)
            {
                TempData["Mesaj"] = new TempDataDictionary {
                    { "durum", " alert alert-success" },
                    { "mesaj", model.Id + "" + model.Semt + " isimli kayıt eklendi." }
                };

                return RedirectToAction(nameof(Index));
            }
            return View();
        }


    }
}