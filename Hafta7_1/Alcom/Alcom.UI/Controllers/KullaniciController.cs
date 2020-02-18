using Alcom.BLL;
using Alcom.MODEL;
using Alcom.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Kaydol()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydol(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (KullaniciRepository repo = new KullaniciRepository())
                {
                    bool durum = repo.Ekle(new MODEL.Kullanici { SonGirisZamani = DateTime.Now, Ad = model.Ad, DogumTarihi = model.DogumTarihi, Durum = 1, Email = model.Email, KayitTarihi = DateTime.Now, KullaniciAdi = model.KullaniciAdi, Sifre = model.Sifre, Soyad = model.Soyad });
                    TempData["Mesaj"] = durum ? new TempDataDictionary { { "class", "alert alert-success" }, { "mesaj", "Kayıt eklendi." } } : new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Kayıt eklenemedi." } };
                    return RedirectToAction("Index", "Kategori");
                }
            }
            return View();
        }

        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (KullaniciRepository repo = new KullaniciRepository())
                {
                    Kullanici durum = repo.Getir(x => x.KullaniciAdi == model.KullaniciAdi && x.Sifre == model.Sifre && x.SilindiMi == false);

                    if (durum != null)
                    {
                        TempData["Mesaj"] = new TempDataDictionary { { "class", "alert alert-success" }, { "mesaj", "Başarılı." } };
                        Session["lgnUser"] = durum;
                        return RedirectToAction("Index", "Kategori");
                    }
                    else
                    {
                        TempData["Mesaj"] = new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Başarısız." } };
                        return View();
                    }
                }
            }
            TempData["Mesaj"] = new TempDataDictionary { { "class", "alert alert-danger" }, { "mesaj", "Bilgileri eksiksiz giriniz." } };
            return View();
        }

        public ActionResult CikisYap()
        {
            Session["lgnUser"] = null;
            Session.Remove("lgnUser");
            Session.Abandon();
            return RedirectToAction("GirisYap");
        }
    }
}