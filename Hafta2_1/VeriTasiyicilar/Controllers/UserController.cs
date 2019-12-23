using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeriTasiyicilar.FakeDataHelper;
using VeriTasiyicilar.Models;

namespace VeriTasiyicilar.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<Models.User> userList = FakeDataHelper.VeriUret.CreateUserList();
            List<Models.Role> roleList = FakeDataHelper.VeriUret.CreateRoleList();
            UserRoleViewModel vm = new UserRoleViewModel( );
            vm.Users = userList;
            vm.Roles = roleList;

            return View(vm);
        }

        public ActionResult FilterByRole(int id)
        {
            List<Models.User> userList = VeriUret.CreateUserList().Where(x => x.RoleId == id).ToList();
            Role selectedRole = VeriUret.CreateRoleList().Find(x => x.Id == id);

            ViewBag.Message = selectedRole.Name + " rolüne sahip kullanıcılar listelenmiştir.";
            ViewBag.Count = userList.Count + " adet kayıt bulumuştur.";

            ViewData["VDMessage"] = selectedRole.Name + " rolüne sahip kullanıcılar (viewdata) listelenmiştir.";
                       

            return View(userList);
        }

        public ActionResult Sayfa1()
        {
            TempData["TDMessage"] = "Sayfa1 actionda oluşturuldu";
            return RedirectToAction(nameof(Sayfa2));
        }

        public ActionResult Sayfa2()
        {
            var data = TempData["TDMessage"];

            Tuple<int, string, Role, User> myTuple = 
                new Tuple<int, string, Role, User>(10,"string veri", new Role(), new User());

            return View(myTuple);

        }
    }
}