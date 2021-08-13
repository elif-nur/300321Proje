using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _300321Proje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        UserManager userManager = new UserManager(new EfUserDal());
        public ActionResult Manager_Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return RedirectToAction("Manager_Login");
        }
        [HttpPost]
        public ActionResult Login(User user)
        {


            try
            {
                if (ModelState.IsValid)
                {
                    var kullanici = userManager.Find(user.Username, user.Password);
                    if (kullanici != null)
                    {
                        FormsAuthentication.SetAuthCookie("Kullanici", false);
                        Session["Kullanici"] = kullanici;
                        return RedirectToAction("Index", "ManagerPanel");
                    }
                    else
                    {

                        return View();
                    }
                }

            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Geçersiz kullanıcı");
                ViewBag.mesaj = "Geçersiz kullanıcı";
                return RedirectToAction("Manager_Login");

            }
            ViewBag.mesaj = "Geçersiz kullanıcı";
            return RedirectToAction("Manager_Login");


        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Remove("Kullanici");
            return RedirectToAction("Manager_Login");
        }
    }
}