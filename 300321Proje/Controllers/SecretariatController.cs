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
    public class SecretariatController : Controller
    {
        // GET: Secretariat
        SecretariatManager secretariatManager = new SecretariatManager(new EfSecretariatDal());
        public ActionResult Index()
        {
            List<Secretariat> model = secretariatManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Secretariat secretariat)
        {
            if (ModelState.IsValid)
            {
                secretariatManager.Add(secretariat);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Secretariat secretariat)
        {
            secretariatManager.Delete(secretariat);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Secretariat secretariat)
        {
            var deger = secretariatManager.Get(secretariat.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Secretariat secretariat)
        {
            secretariatManager.Update(secretariat);
            return RedirectToAction("Index");
        }
    }
}