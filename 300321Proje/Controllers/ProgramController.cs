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
    public class ProgramController : Controller
    {
        // GET: Program
        ProgramManager programManager = new ProgramManager(new EfProgramDal());
        public ActionResult Index()
        {
            List<Program> model = programManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Program program)
        {
            if (ModelState.IsValid)
            {
                programManager.Add(program);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Program program)
        {
            programManager.Delete(program);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Program program)
        {
            var deger = programManager.Get(program.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Program program)
        {

            programManager.Update(program);
            return RedirectToAction("Index");

        }
    }
}