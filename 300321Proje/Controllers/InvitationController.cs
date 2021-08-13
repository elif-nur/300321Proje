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
    public class InvitationController : Controller
    {
        // GET: Invitation
        InvitationManager invitationManager = new InvitationManager(new EfInvitationDal());
        public ActionResult Index()
        {
            List<Invitation> model = invitationManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Invitation invitation)
        {
            if (ModelState.IsValid)
            {
                invitationManager.Add(invitation);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(Invitation invitation)
        {
            invitationManager.Delete(invitation);
            return RedirectToAction("Index");
        }
        public ActionResult Update(Invitation invitation)
        {
            var deger = invitationManager.Get(invitation.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Invitation invitation)
        {

            invitationManager.Update(invitation);
            return RedirectToAction("Index");

        }
    }
}