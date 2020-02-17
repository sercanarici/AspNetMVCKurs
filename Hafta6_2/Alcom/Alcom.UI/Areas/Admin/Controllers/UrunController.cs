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
    public class UrunController : Controller
    {
        // GET: Admin/Urun
        //[LoginFilter]
        public ActionResult Index()
        {
            using (UrunRepository repo = new UrunRepository())
            {
                var model = repo.Listele();
                return View(model);
            }
        }

        // GET: Admin/Urun/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Urun/Create
        public ActionResult Create()
        {
            using (KategoriRepository kategoriler = new KategoriRepository())
            {
                ViewBag.Kategoriler = kategoriler.Listele(x=>x.SilindiMi==false);
            }

            using (MarkaBilgileriRepository markalar = new MarkaBilgileriRepository())
            {
                ViewBag.Markalar = markalar.Listele(x => x.SilindiMi == false);
            }
            return View();
        }

        // POST: Admin/Urun/Create
        [HttpPost]
        public ActionResult Create(Urun model)
        {
            try
            {
                using (KategoriRepository kategoriler = new KategoriRepository())
                {
                    ViewBag.Kategoriler = kategoriler.Listele(x => x.SilindiMi == false);
                }

                using (MarkaBilgileriRepository markalar = new MarkaBilgileriRepository())
                {
                    ViewBag.Markalar = markalar.Listele(x => x.SilindiMi == false);
                }

                // TODO: Add insert logic here
                using (UrunRepository repo = new UrunRepository())
                {
                    model.KayitTarihi = DateTime.Now;
                    bool durum = repo.Ekle(model);                   
                    return RedirectToAction("Index");
                }
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Urun/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Urun/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Urun/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Urun/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
