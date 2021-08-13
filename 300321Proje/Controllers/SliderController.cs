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
    public class SliderController : Controller
    {
        // GET: Slider
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        public ActionResult Index()
        {
            List<Slider> model = sliderManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Slider slider)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Images/" + dosyaadi;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    slider.ImagePath = "/Images/" + dosyaadi;
                }
                sliderManager.Add(slider);
                return RedirectToAction("Index", "Slider");
            }
            return View();

        }

        public ActionResult Delete(Slider slider)
        {
            sliderManager.Delete(slider);
            return RedirectToAction("Index");
        }
    }
}