using Alcom.BLL;
using Alcom.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            ICollection<Urun> model = new List<Urun>();
            ICollection<Kategori> kategoriler = new List<Kategori>();

            using (KategoriRepository kategoriRepo = new KategoriRepository())
            {
                kategoriler = kategoriRepo.Listele(x => x.SilindiMi == false);
            }

            using (UrunRepository repo = new UrunRepository())
            {
                model = repo.Listele();                
            }

            ViewBag.Kategoriler = kategoriler;
            return View(model);
        }

        // GET: Urun/Details/5
        public ActionResult Details(int id)
        {
            using (UrunRepository repo = new UrunRepository())
            {
                var model = repo.Getir(x => x.Id == id);
                return View(model);
            }
        }
       
    }
}
