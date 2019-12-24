using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RazorVeHtmlHelper.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Doğum Tarihi")]
        public DateTime DOB { get; set; }
    }
}