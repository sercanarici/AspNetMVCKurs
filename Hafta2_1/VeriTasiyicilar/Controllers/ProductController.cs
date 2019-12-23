using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeriTasiyicilar.Models;

namespace VeriTasiyicilar.Controllers
{
    public class ProductController : Controller
    {
        List<Product> urunler = FakeDataHelper.VeriUret.CreateProductList();
        List<Category> kategoriler = FakeDataHelper.VeriUret.CreateCategoryList();
        // GET: Product
        public ActionResult Index()
        {

            ViewData["Products"] = urunler;
            ViewData["Categories"] = kategoriler;


            return View();
        }

        public ActionResult FilterByCategory(int id)
        {
            var kategori = kategoriler.Find(x => x.Id == id);
            List<Product> urunFilter = urunler.Where(x => x.CategoryId == kategori.Id).ToList();
            ViewBag.Kategori = kategori.CategoryName;
            return View(urunFilter);
        }

        public ActionResult ProductDetail(int id)
        {
            return View();
        }
    }
}