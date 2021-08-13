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
    public class ManagerPanelController : Controller
    {
        // GET: ManagerPanel
        FirstPageManager firstPageManager = new FirstPageManager(new EfFirstPageDal());
        public ActionResult Index()
        {
            List<FirstPage> model = firstPageManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FirstPage firstPage)
        {
            if (ModelState.IsValid)
            {
                firstPageManager.Add(firstPage);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(FirstPage firstPage)
        {
            firstPageManager.Delete(firstPage);
            return RedirectToAction("Index");
        }
        public ActionResult Update(FirstPage firstPage)
        {
            var deger = firstPageManager.Get(firstPage.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(FirstPage firstPage)
        {

            firstPageManager.Update(firstPage);
            return RedirectToAction("Index");

        }
    }
}