using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _300321Proje.Controllers
{
    [Authorize]
    public class SponsorController : Controller
    {
        // GET: Sponsor
        SponsorManager sponsorManager = new SponsorManager(new EfSponsorDal());
        public ActionResult Index()
        {
            List<Sponsor> model = sponsorManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Sponsor sponsor)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Images/" + dosyaadi;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    sponsor.ImagePath = "/Images/" + dosyaadi;
                }
                sponsorManager.Add(sponsor);
                return RedirectToAction("Index", "Sponsor");
            }
            return View();

        }

        public ActionResult Delete(Sponsor sponsor)
        {
            sponsorManager.Delete(sponsor);
            return RedirectToAction("Index");
        }
    }
}
