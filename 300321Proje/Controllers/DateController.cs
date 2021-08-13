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
    public class DateController : Controller
    {
        // GET: Date
        DateManager dateManager = new DateManager(new EfDateDal());
        public ActionResult Index()
        {
            List<Date> model = dateManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Date date)
        {
            if (ModelState.IsValid)
            {
                dateManager.Add(date);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Date date)
        {
            dateManager.Delete(date);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Date date)
        {
            var deger = dateManager.Get(date.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Date date)
        {
            dateManager.Update(date);
            return RedirectToAction("Index");
        }
    }
}