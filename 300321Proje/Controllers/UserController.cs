using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _300321Proje.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // GET: User
        UserManager userManager = new UserManager(new EfUserDal());
        public ActionResult Index()
        {
            List<User> model = userManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                userManager.Add(user);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(User user)
        {
            userManager.Delete(user);
            return RedirectToAction("Index");
        }
        public ActionResult Update(User user)
        {
            var deger = userManager.Get(user.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(User user)
        {
            userManager.Update(user);
            return RedirectToAction("Index");
        }
    }
}