using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeriTasiyicilar.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
    }
}