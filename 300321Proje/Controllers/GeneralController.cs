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
    public class GeneralController : Controller
    {
        // GET: General
        GeneralManager generalManager = new GeneralManager(new EfGeneralDal());
        public ActionResult Index()
        {
            List<General> model = generalManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(General general)
        {
            if (ModelState.IsValid)
            {
                generalManager.Add(general);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(General general)
        {
            generalManager.Delete(general);
            return RedirectToAction("Index");
        }
        public ActionResult Update(General general)
        {
            var deger = generalManager.Get(general.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(General general)
        {

            generalManager.Update(general);
            return RedirectToAction("Index");

        }
    }
}