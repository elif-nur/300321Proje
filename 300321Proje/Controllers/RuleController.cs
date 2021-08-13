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
    public class RuleController : Controller
    {
        // GET: Rule
        RuleManager ruleManager = new RuleManager(new EfRuleDal());
        public ActionResult Index()
        {
            List<Rule> model = ruleManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Rule rule)
        {
            if (ModelState.IsValid)
            {
                ruleManager.Add(rule);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Rule rule)
        {
            ruleManager.Delete(rule);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Rule rule)
        {
            var deger = ruleManager.Get(rule.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Rule rule)
        {
            ruleManager.Update(rule);
            return RedirectToAction("Index");
        }
    }
}