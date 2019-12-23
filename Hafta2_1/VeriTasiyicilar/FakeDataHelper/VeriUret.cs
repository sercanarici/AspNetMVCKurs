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

        public static List<Category> CreateCategoryList()
        {
            List<Category> kategoriler = new List<Category>();
            kategoriler.Add(new Category { Id = 1, CategoryName = "Elektronik" });
            kategoriler.Add(new Category { Id = 2, CategoryName = "Kitap" });
            kategoriler.Add(new Category { Id = 3, CategoryName = "Mobilya" });
            return kategoriler;
        }

        public static List<Product> CreateProductList()
        {
            List<Product> urunler = new List<Product>();
            urunler.Add(new Product { Id = 1, ProductName = "Hesap Makinesi", CategoryId = 1 });
            urunler.Add(new Product { Id = 2, ProductName = "Ölçü aleti", CategoryId = 1 });
            urunler.Add(new Product { Id = 3, ProductName = "asp.net mvc kitabı", CategoryId = 2 });
            urunler.Add(new Product { Id = 4, ProductName = "django framework kitabı", CategoryId = 2 });
            urunler.Add(new Product { Id = 5, ProductName = "Sandalye", CategoryId = 3 });
            urunler.Add(new Product { Id = 6, ProductName = "Koltuk", CategoryId = 3 });
            return urunler;
        }



    }
}