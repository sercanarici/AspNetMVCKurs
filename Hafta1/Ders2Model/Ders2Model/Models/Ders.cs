using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ders2Model.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string DersAdi { get; set; }
        public string Eğitmen { get; set; }
        public int Kredi { get; set; }
    }
}