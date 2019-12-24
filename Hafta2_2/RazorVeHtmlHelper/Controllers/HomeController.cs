using RazorVeHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorVeHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<SelectListItem> liste = new List<SelectListItem>();
            liste.Add(new SelectListItem { Text = "Istanbul", Value = "34" });
            liste.Add(new SelectListItem { Text = "Ankara", Value = "34" });
            liste.Add(new SelectListItem { Text = "Bursa", Value = "16" });
            liste.Add(new SelectListItem { Text = "Trabzon", Value = "34" });

            ViewBag.Iller = liste;

            return View();
        }

        public ActionResult Reklam()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {

            return View();
        }
    }
}