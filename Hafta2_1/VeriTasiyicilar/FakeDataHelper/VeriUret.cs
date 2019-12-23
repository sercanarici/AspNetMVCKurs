using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VeriTasiyicilar.Models;

namespace VeriTasiyicilar.FakeDataHelper
{
    public class VeriUret
    {
        public static List<User> CreateUserList()
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = 10, Address = "İstanbul", Email = "fby@gmail.com", FullName = "Fatma Betül Yılmaz", RoleId = 1 });
            users.Add(new User { Id = 11, Address = "Göztepe", RoleId = 2, FullName = "Serkan Aydoğdu", Email = "sa@gmail.com" });
            users.Add(new User { Id = 12, Address = "Halkalı", RoleId = 2, Email = "ga@gmail.com", FullName = "Gülden Arslanoğlu" });
            users.Add(new User { Id = 13, Address = "Bakırköy", RoleId = 1, Email = "erkan@gmail.com", FullName = "Erkan Yıldız" });
            users.Add(new User { Id = 14, Address = "Kadıköy", RoleId = 1, Email = "murat@gmail.com", FullName = "Murat Turan" });
            users.Add(new User { Id = 15, Address = "Şehremini", Email = "mehmet@gmail.com", FullName = "Mehmet Bilgin", RoleId = 1 });
            users.Add(new User { Id = 16, Address = "Bahçelievler", RoleId = 2, FullName = "İsmail Sönmez", Email = "ismail@gmail.com" });
            return users;
        }

        public static List<Role> CreateRoleList()
        {
            List<Role> roles = new List<Role>();
            roles.Add(new Role { Id = 1, Name = "Admin" });
            roles.Add(new Role { Id = 2, Name = "System User" });
            return roles;
        }

    }
}