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
    public class OrganisingController : Controller
    {
        // GET: Organising
        OrganisingManager organisingManager = new OrganisingManager(new EfOrganisingDal());
        public ActionResult Index()
        {
            List<Organising> model = organisingManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Organising organising)
        {
            if (ModelState.IsValid)
            {
                organisingManager.Add(organising);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Organising organising)
        {
            organisingManager.Delete(organising);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Organising organising)
        {
            var deger = organisingManager.Get(organising.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Organising organising)
        {
            organisingManager.Update(organising);
            return RedirectToAction("Index");
        }
    }
}