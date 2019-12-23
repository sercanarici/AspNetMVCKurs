using Ders2Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders2Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DateTime zaman = DateTime.Now;
            return View(zaman);
        }

        public ActionResult Liste()
        {
            int[] sayilar = new int[] { 2, 3, 4, 5, 6 };
            return View(sayilar);

        }

        public ActionResult Dersim()
        {
            Ders ders = new Ders();
            ders.Id = 10;
            ders.DersAdi = "Ders Adi";
            ders.Eğitmen = "Fatma Betül yılmaz";
            ders.Kredi = 10;
            return View(ders);
        }

    }
}
