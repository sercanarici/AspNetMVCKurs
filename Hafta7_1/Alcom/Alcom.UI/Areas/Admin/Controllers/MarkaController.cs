using Alcom.BLL;
using Alcom.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Areas.Admin.Controllers
{
    public class MarkaController : Controller
    {
        // GET: Admin/Marka
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Marka/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Marka/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Marka/Create
        [HttpPost]
        public ActionResult Create(MarkaBilgileri model)
        {
            try
            {
                // TODO: Add insert logic here
                using (MarkaBilgileriRepository repo = new MarkaBilgileriRepository())
                {
                    model.KayitTarihi = DateTime.Now;
                    repo.Ekle(model);

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Marka/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Marka/Edit/5
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

        // GET: Admin/Marka/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Marka/Delete/5
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
