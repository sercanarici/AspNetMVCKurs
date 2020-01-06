using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpRequests.Models
{
    public class Emlak
    {
        public int Id { get; set; }
        public int OdaSayisi { get; set; }
        public string Semt { get; set; }
        public string Sehir { get; set; }        

    }
}