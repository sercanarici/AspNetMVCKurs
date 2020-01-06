using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpRequests.Models
{
    public class HazirKullaniciListesi: List<Kullanici>
    {
        public HazirKullaniciListesi()
        {
            this.Add(new Kullanici { Ad = "Serkan", Id = 1, DogumTarihi = Convert.ToDateTime("12.12.2010"), Soyad = "Aydoğdu", Mail = "serkan@gmail.com", Sifre = "123Asd", SifreTekrar = "123Asd" });
            this.Add(new Kullanici { Ad = "Gülden", Id = 1, DogumTarihi = Convert.ToDateTime("12.10.2012"), Soyad = "Arslanoğlu", Mail = "gulden@gmail.com", Sifre = "123Asd", SifreTekrar = "123Asd" });
            this.Add(new Kullanici { Ad = "Furkan", Id = 2, DogumTarihi = Convert.ToDateTime("10.12.2012"), Soyad = "Çakıcı", Mail = "furkan@gmail.com", Sifre = "123Asd", SifreTekrar = "123Asd" });
            //this.Add(new Kullanici { Id = 1, Ad = "Erman", Soyad = "Tektaş", Mail = "", DogumTarihi = Convert.ToDateTime("01.01.1980"), Sifre = "", SifreTekrar = "" });
            //this.Add(new Kullanici { Id = 2, Ad = "Selçuk", Soyad = "Denizger", Mail = "", DogumTarihi = Convert.ToDateTime("01.01.1981"), Sifre = "", SifreTekrar = "" });
            //this.Add(new Kullanici { Id = 3, Ad = "Aygün", Soyad = "Acar", Mail = "", DogumTarihi = Convert.ToDateTime("01.01.1982"), Sifre = "", SifreTekrar = "" });
            //this.Add(new Kullanici { Id = 4, Ad = "Nejdet", Soyad = "Işık", Mail = "", DogumTarihi = Convert.ToDateTime("01.01.1983"), Sifre = "", SifreTekrar = "" });
            //this.Add(new Kullanici { Id = 5, Ad = "Barış", Soyad = "Aydın", Mail = "", DogumTarihi = Convert.ToDateTime("01.01.1984"), Sifre = "", SifreTekrar = "" });
            //this.Add(new Kullanici { Id = 6, Ad = "Sergen", Soyad = "Arıcı", Mail = "", DogumTarihi = Convert.ToDateTime("01.01.1985"), Sifre = "", SifreTekrar = "" });
        }
    }
}