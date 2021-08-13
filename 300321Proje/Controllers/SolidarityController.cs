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
    public class SolidarityController : Controller
    {
        // GET: Solidarity
        SolidarityManager solidarityManager = new SolidarityManager(new EfSolidarityDal());
        public ActionResult Index()
        {
            List<Solidarity> model = solidarityManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Solidarity solidarity)
        {
            if (ModelState.IsValid)
            {
                solidarityManager.Add(solidarity);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Solidarity solidarity)
        {
            solidarityManager.Delete(solidarity);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Solidarity solidarity)
        {
            var deger = solidarityManager.Get(solidarity.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Solidarity solidarity)
        {
            solidarityManager.Update(solidarity);
            return RedirectToAction("Index");
        }
    }
}