using Ders2Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ders2Model.Controllers
{
    public class OgrenciController : Controller
    {        
        
        // GET: Ogenci
        public ActionResult Index()
        {
            var ogrenci = getOgrenciler().First();

            return View(ogrenci);
        }

        public ActionResult Ogrenciler()
        {
            var ogrenciler = getOgrenciler();            
            return View(ogrenciler);
        }

        public ActionResult Liste()
        {
            OgrenciViewModel vm = new OgrenciViewModel();
            vm.Dersler = getDersler();
            vm.Ogrenciler = getOgrenciler();
            return View(vm);
        }

        public List<Ders> getDersler()
        {
            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders { Id = 1, DersAdi = "Asp.NEt MVC", Eğitmen = "Fatma Betül KAya", Kredi = 10});
            dersler.Add(new Ders { Id = 2, DersAdi = "Django Framework", Eğitmen = "R. Sercan Arıcı", Kredi = 20});
            dersler.Add(new Ders { Id = 3, DersAdi = "Ms Sql", Eğitmen = "Larry Page", Kredi = 30});
            return dersler;
        }

        public List<Ogrenci> getOgrenciler()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci { Id = 0, Ad = "Sercan", Soyad = "Arıcı", OgrenciNo = 1, DogumTarihi = new DateTime(1982, 07, 14) });
            ogrenciler.Add(new Ogrenci { Id = 1, Ad = "Erman", Soyad = "Tektaş", OgrenciNo = 2, DogumTarihi = new DateTime(1982, 02, 20) });
            ogrenciler.Add(new Ogrenci { Id = 2, Ad = "Selçuk", Soyad = "Denizger", OgrenciNo = 3, DogumTarihi = new DateTime(1982, 07, 14) });
            return ogrenciler;
        }


    }
}