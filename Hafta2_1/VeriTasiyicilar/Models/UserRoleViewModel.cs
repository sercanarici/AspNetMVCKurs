using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeriTasiyicilar.Models
{
    public class UserRoleViewModel
    {
        public List<User> Users { get; set; }
        public List<Role> Roles { get; set; }
    }
}