using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HttpRequests.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Ad en az 2, en fazla 20 karakterden oluşmalıdır.", MinimumLength = 2)]
        public string Ad { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Soyad en az 2, en fazla 20 karakterden oluşmalıdır.", MinimumLength = 2)]
        public string Soyad { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Mail { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Şifre en az 6, en fazla 20 karakter olmalıdır.", MinimumLength = 6)]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\\]*+\\/|!\"£$%^&*()#[@~'?><,.=_-]).{6,}$", ErrorMessage ="sifre kucuk harf,  buyuk harf, sayı ve özel karakter içermelidir.")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        [Compare("Sifre")]
        public string SifreTekrar { get; set; }
    }
}