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
    public class ScientificController : Controller
    {
        // GET: Scientific
        ScientificManager scientificManager = new ScientificManager(new EfScientificDal());
        public ActionResult Index()
        {
            List<Scientific> model = scientificManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Scientific scientific)
        {
            if (ModelState.IsValid)
            {
                scientificManager.Add(scientific);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Scientific scientific)
        {
            scientificManager.Delete(scientific);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Scientific scientific)
        {
            var deger = scientificManager.Get(scientific.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Scientific scientific)
        {
            scientificManager.Update(scientific);
            return RedirectToAction("Index");
        }
    }
}