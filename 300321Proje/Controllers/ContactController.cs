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
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            List<Contact> model = contactManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contactManager.Add(contact);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Contact contact)
        {
            contactManager.Delete(contact);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Contact contact)
        {
            var deger = contactManager.Get(contact.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Contact contact)
        {
            contactManager.Update(contact);
            return RedirectToAction("Index");
        }
    }
}