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
    public class HomeController : Controller
    {
        FirstPageManager firstPageManager = new FirstPageManager(new EfFirstPageDal());
        SponsorManager sponsorManager = new SponsorManager(new EfSponsorDal());
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        DateManager dateManager = new DateManager(new EfDateDal());
        RuleManager ruleManager = new RuleManager(new EfRuleDal());
        SolidarityManager solidarityManager = new SolidarityManager(new EfSolidarityDal());
        CultureManager cultureManager = new CultureManager(new EfCultureDal());
        SportManager sportManager = new SportManager(new EfSportDal());
        HonoraryManager honoraryManager = new HonoraryManager(new EfHonoraryDal());
        SecretariatManager secretariatManager = new SecretariatManager(new EfSecretariatDal());
        OrganisingManager organisingManager = new OrganisingManager(new EfOrganisingDal());
        ScientificManager scientificManager = new ScientificManager(new EfScientificDal());
        CardManager cardManager = new CardManager(new EfCardDal());
        ProgramManager programManager = new ProgramManager(new EfProgramDal());
        InvitationManager invitationManager = new InvitationManager(new EfInvitationDal());
        GeneralManager generalManager = new GeneralManager(new EfGeneralDal());
        RegistrationManager registrationManager = new RegistrationManager(new EfRegistrationDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());
        AccountManager accountManager = new AccountManager(new EfAccountDal());
        WritingManager writingManager = new WritingManager(new EfWritingDal());
        SubmitManager abstractTblManager = new SubmitManager(new EfSubmitDal());
        FullSubmitManager fullSubmitManager = new FullSubmitManager(new EfFullSubmitDal());
        AcceptedManager acceptedManager = new AcceptedManager(new EfAcceptedDal());
     
        public ActionResult Index()
        {
            var model = firstPageManager.GetAll();
            ViewBag.anasayfa = model;

            var resim = cardManager.GetAll();
            ViewBag.resim = resim;
            return View();
        }

        public ActionResult Abstract_Rules()
        {
            var model = ruleManager.GetAll();
            return View(model);
        }
        public ActionResult Writing_Rules()
        {
            var model = writingManager.GetAll();
            return View(model);
        }
        public ActionResult Submit_Abstract()
        {
            
            return View();
        }
        public ActionResult Accepted_Abstract()
        {
            var model = acceptedManager.GetAll();
            return View(model);
        }
        public ActionResult Submit()
        {
            return View();
        }
        public ActionResult Important_Date()
        {
            var model = dateManager.GetAll();
            
            return View(model);
        }
        public ActionResult Committee()
        {
            var honorary = honoraryManager.GetAll();
            ViewBag.honorary = honorary;

            var scientific = scientificManager.GetAll();
            ViewBag.scientific = scientific;

            var secretariat = secretariatManager.GetAll();
            ViewBag.secretariat = secretariat;

            var organising = organisingManager.GetAll();
            ViewBag.organising = organising;
            return View();
        }
        public ActionResult Subject_Headings()
        {
            var sport = sportManager.GetAll();
            ViewBag.sport = sport;

            var culture = cultureManager.GetAll();
            ViewBag.culture = culture;

            var solidarity = solidarityManager.GetAll();
            ViewBag.solidarity = solidarity;
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Registration registration)
        {

            if (ModelState.IsValid)
            {
                if (registrationManager.Add(registration))
                {
                  
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.mesaj = "Application cannot be made with the same e-mail address.";
                    return View();
                }


            }
            return View();

        }
        [HttpPost]
        public ActionResult Submit_Abstract(Submit upload, HttpPostedFileBase Filee)
        {

            if (Filee != null && Filee.ContentLength > 0)
            {
                var fileName = Path.GetFileName(Filee.FileName);
                var guid = Guid.NewGuid().ToString();
                var path = Path.Combine(Server.MapPath("~/Uploads"),  fileName);
                Filee.SaveAs(path);
                string fl = path.Substring(path.LastIndexOf("\\"));
                string[] split = fl.Split('\\');
                string newpath = split[1];
                string imagepath =  newpath;
                upload.Filee = imagepath;
                abstractTblManager.Add(upload);

            }
            TempData["Success"] = "Successful";
            return RedirectToAction("Submit_Abstract");
          

        }

        [HttpPost]
        public ActionResult Submit(FullSubmit upload, HttpPostedFileBase Filee)
        {

            if (Filee != null && Filee.ContentLength > 0)
            {
                    var fileName = Path.GetFileName(Filee.FileName);
                    var guid = Guid.NewGuid().ToString();
                    var path = Path.Combine(Server.MapPath("~/Uploads"), fileName);
                    Filee.SaveAs(path);
                    string fl = path.Substring(path.LastIndexOf("\\"));
                    string[] split = fl.Split('\\');
                    string newpath = split[1];
                    string imagepath = newpath;
                    upload.Filee = imagepath;
                    fullSubmitManager.Add(upload);
              
            }
            TempData["Success"] = "Successful";
            return RedirectToAction("Submit");


        }


        public ActionResult Program()
        {
            var model = programManager.GetAll();
            return View(model);
        }
        public ActionResult Slider()
        {
            var model = sliderManager.GetAll();
            return PartialView(model);
        }
        public ActionResult Invitation()
        {
            var model = invitationManager.GetAll();
            return View(model);
        }
        public ActionResult Sponsor()
        {
            var model = sponsorManager.GetAll();
            return PartialView(model);
        }
        public ActionResult Footer()
        {
            var model = contactManager.GetAll();
            ViewBag.deger = model;

            var media = accountManager.GetAll();
            ViewBag.dgr = media;
            return PartialView();
        }

        public ActionResult Contact()
        {
            var model = contactManager.GetAll();
            return View(model);
        }
        public ActionResult General_Information()
        {
            var model = generalManager.GetAll();
            return View(model);
        }
        public ActionResult SocialMedia()
        {
            var model = accountManager.GetAll();
            return PartialView(model);
        }
        public ActionResult Menu() 
        {
            return PartialView();
        }

    }
}