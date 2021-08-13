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
    public class AccountController : Controller
    {
        // GET: Account
        AccountManager accountManager = new AccountManager(new EfAccountDal());
        public ActionResult Index()
        {
            List<Account> model = accountManager.GetAll();
            return View(model);
        }

      
        public ActionResult Update(Account account)
        {
            var deger = accountManager.Get(account.Id);
            return View("Update", deger);
        }
        [HttpPost]
        public ActionResult Updatee(Account account)
        {
            accountManager.Update(account);
            return RedirectToAction("Index");
        }
    }
}