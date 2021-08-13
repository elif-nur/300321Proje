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
    public class AcceptedController : Controller
    {
        // GET: Accepted
        AcceptedManager acceptedManager = new AcceptedManager(new EfAcceptedDal());
        public ActionResult Index()
        {
            List<Accepted> model = acceptedManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Accepted accepted)
        {
            if (ModelState.IsValid)
            {
                acceptedManager.Add(accepted);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Accepted accepted)
        {
            acceptedManager.Delete(accepted);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Accepted accepted)
        {
            var deger = acceptedManager.Get(accepted.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Accepted accepted)
        {
            acceptedManager.Update(accepted);
            return RedirectToAction("Index");
        }
    }
}