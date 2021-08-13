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
    public class CardController : Controller
    {
        // GET: Card
        CardManager cardManager = new CardManager(new EfCardDal());
        public ActionResult Index()
        {
            List<Card> model = cardManager.GetAll();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Card card)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/Images/" + dosyaadi;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    card.ImagePath = "/Images/" + dosyaadi;
                }
                cardManager.Add(card);
                return RedirectToAction("Index", "Card");
            }
            return View();

        }

        public ActionResult Delete(Card card)
        {
            cardManager.Delete(card);
            return RedirectToAction("Index");
        }
    }
}