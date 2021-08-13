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
    public class RegistrationController : Controller
    {
        // GET: Registration
        RegistrationManager registrationManager = new RegistrationManager(new EfRegistrationDal());

        public ActionResult Index()
        {
            List<Registration> model = registrationManager.GetAll();
            return View(model);
        }
       
        public ActionResult Delete(Registration registration)
        {
            registrationManager.Delete(registration);
            return RedirectToAction("Index");
        }

        public ActionResult Update(Registration registration)
        {
            var deger = registrationManager.Get(registration.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Registration registration)
        {
            registrationManager.Update(registration);
            return RedirectToAction("Index");
        }
        public FileResult Download(Registration file)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Uploads/" + file + ""));
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, file.Filee);
        }
    }
}