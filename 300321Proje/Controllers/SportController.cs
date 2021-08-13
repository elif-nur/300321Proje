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
    public class SportController : Controller
    {
        // GET: Sport
        SportManager sportManager = new SportManager(new EfSportDal());
        public ActionResult Index()
        {
            List<Sport> model = sportManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Sport sport)
        {
            if (ModelState.IsValid)
            {
                sportManager.Add(sport);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Sport sport)
        {
            sportManager.Delete(sport);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Sport sport)
        {
            var deger = sportManager.Get(sport.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Sport sport)
        {
            sportManager.Update(sport);
            return RedirectToAction("Index");
        }
    }
}