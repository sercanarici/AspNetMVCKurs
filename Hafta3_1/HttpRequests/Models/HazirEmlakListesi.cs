using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpRequests.Models
{
    public class HazirEmlakListesi : List<Emlak>
    {
        public HazirEmlakListesi()
        {
            this.Add(new Emlak { Id = 1, OdaSayisi = 1, Sehir = "Istanbul", Semt = "Üsküdar" });
            this.Add(new Emlak { Id = 2, OdaSayisi = 2, Sehir = "Istanbul", Semt = "Bakırköy" });
            this.Add(new Emlak { Id = 3, OdaSayisi = 3, Sehir = "Istanbul", Semt = "Pendik" });
            this.Add(new Emlak { Id = 4, OdaSayisi = 4, Sehir = "Ankara", Semt = "Keçiören" });
        }
    }
}