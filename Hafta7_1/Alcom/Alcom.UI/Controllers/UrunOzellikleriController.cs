using Alcom.BLL;
using Alcom.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Areas.Admin.Controllers
{
    public class UrunOzellikleriController : Controller
    {
        // GET: Admin/UrunOzellikleri
        public ActionResult Index()
        {
            using (var repo = new UrunOzellikleriRepository())
            {
                var liste = repo.Listele(x => x.SilindiMi == false);
                return View(liste);
            }            
        }

        // GET: Admin/UrunOzellikleri/Details/5
        public ActionResult Details(int id)
        {
            using (var repo = new UrunOzellikleriRepository())
            {
                var detay = repo.Getir(x => x.Id == id);
                return View(detay);
            }            
        }

        // GET: Admin/UrunOzellikleri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/UrunOzellikleri/Create
        [HttpPost]
        public ActionResult Create(UrunOzellikleri model)
        {
            try
            {
                // TODO: Add insert logic here

                using (var repo = new UrunOzellikleriRepository())
                {
                    model.KayitTarihi = DateTime.Now;
                    var result = repo.Ekle(model);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/UrunOzellikleri/Edit/5
        public ActionResult Edit(int id)
        {
            using (var repo = new UrunOzellikleriRepository())
            {
                var detay = repo.Getir(x => x.Id == id);
                return View(detay);
            }
        }

        // POST: Admin/UrunOzellikleri/Edit/5
        [HttpPost]
        public ActionResult Edit(UrunOzellikleri model)
        {
            try
            {
                // TODO: Add update logic here
                using (var repo = new UrunOzellikleriRepository())
                {
                    model.GuncellemeTarihi = DateTime.Now;
                    var detay = repo.Guncelle(model);
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Admin/UrunOzellikleri/Delete/5
        public ActionResult Delete(int id)
        {
            using (var repo = new UrunOzellikleriRepository())
            {
                var detay = repo.Getir(x => x.Id == id);
                return View(detay);
            }
        }

        // POST: Admin/UrunOzellikleri/Delete/5
        [HttpPost]
        public ActionResult Delete(UrunOzellikleri model)
        {
            try
            {
                // TODO: Add delete logic here
                using (var repo = new UrunOzellikleriRepository())
                {
                    model = repo.Getir(x => x.Id == model.Id);
                    model.SilindiMi = true;
                    model.GuncellemeTarihi = DateTime.Now;
                    var detay = repo.Guncelle(model);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
