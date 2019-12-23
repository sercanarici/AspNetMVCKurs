using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ders2Model.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int OgrenciNo { get; set; }
        public DateTime DogumTarihi { get; set; }

    }
}