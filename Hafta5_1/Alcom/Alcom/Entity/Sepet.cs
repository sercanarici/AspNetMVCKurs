using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alcom.Entity
{
    public class Sepet : Base
    {

        [Required]
        public int KullaniciId { get; set; }
        [Required]
        public decimal ToplamTutar { get; set; }


        [ForeignKey("KullaniciId")]
        public virtual Kullanici  SepetKullanicisi { get; set; }

    }
}