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
    public class FullSubmitController : Controller
    {
        // GET: FullSubmit
        FullSubmitManager submitManager = new FullSubmitManager(new EfFullSubmitDal());

        public ActionResult Index()
        {
            List<FullSubmit> model = submitManager.GetAll();
            return View(model);
        }


        public ActionResult Delete(FullSubmit submit)
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