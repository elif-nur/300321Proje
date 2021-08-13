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
    public class WritingController : Controller
    {
        // GET: Writing
        WritingManager writingManager = new WritingManager(new EfWritingDal());
        public ActionResult Index()
        {
            List<Writing> model = writingManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Writing writing)
        {
            if (ModelState.IsValid)
            {
                writingManager.Add(writing);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Writing writing)
        {
            writingManager.Delete(writing);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Writing writing)
        {
            var deger = writingManager.Get(writing.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Writing writing)
        {
            writingManager.Update(writing);
            return RedirectToAction("Index");
        }
    }
}