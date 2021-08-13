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
    public class SubmitController : Controller
    {
        // GET: Submit
        SubmitManager submitManager = new SubmitManager(new EfSubmitDal());

        public ActionResult Index()
        {
            List<Submit> model = submitManager.GetAll();
            return View(model);
        }
      
       
        public ActionResult Delete(Submit submit)
        {
            submitManager.Delete(submit);
            return RedirectToAction("Index");
        }

       
        public FileResult Download(string file)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Uploads/") + file);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, file);
        }
    }
}