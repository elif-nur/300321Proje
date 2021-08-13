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
    public class CultureController : Controller
    {
        // GET: Culture
        CultureManager cultureManager = new CultureManager(new EfCultureDal());
        public ActionResult Index()
        {
            List<Culture> model = cultureManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Culture culture)
        {
            if (ModelState.IsValid)
            {
                cultureManager.Add(culture);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Culture culture)
        {
            cultureManager.Delete(culture);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Culture culture)
        {
            var deger = cultureManager.Get(culture.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Culture culture)
        {
            cultureManager.Update(culture);
            return RedirectToAction("Index");
        }
    }
}