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
    public class HonoraryController : Controller
    {
        // GET: Honorary
        HonoraryManager honoraryManager = new HonoraryManager(new EfHonoraryDal());
        public ActionResult Index()
        {
            List<Honorary> model = honoraryManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Honorary honorary)
        {
            if (ModelState.IsValid)
            {
                honoraryManager.Add(honorary);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Honorary honorary)
        {
            honoraryManager.Delete(honorary);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Honorary honorary)
        {
            var deger = honoraryManager.Get(honorary.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Honorary honorary)
        {
            honoraryManager.Update(honorary);
            return RedirectToAction("Index");
        }
    }
}