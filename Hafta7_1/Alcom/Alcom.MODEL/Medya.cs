using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcom.MODEL
{
   public class Medya :Base
    {
        [DataType(DataType.ImageUrl)]
        [Required]
        public string Url { get; set; }
        public int UrunId { get; set; }
        //navigation prop
        public virtual Urun Urunu { get; set; }
    }
}
