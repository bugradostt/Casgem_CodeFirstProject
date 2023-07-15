using Casgem_CodeFirstProject.Dal.Context;
using Casgem_CodeFirstProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminController : Controller
    {
        TravelContext c = new TravelContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message()
        {
            var values = c.Contacts.OrderByDescending(x => x.ContactId).ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var foundId = c.Contacts.Find(id);
            c.Contacts.Remove(foundId);
            c.SaveChanges();
            return RedirectToAction("Message");
        }

        public ActionResult ListContact()
        {
            var values = c.ContactInfos.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult EditContact()
        {
            var foundId = c.ContactInfos.Find(1);
            return View(foundId);
        }

        [HttpPost]
        public ActionResult EditContact(ContactInfo p)
        {
            var foundId = c.ContactInfos.Find(p.ContactInfoId);
            foundId.ContactInfoAdress = p.ContactInfoAdress;
            foundId.ContactInfoDes = p.ContactInfoDes;
            foundId.ContactInfoMail = p.ContactInfoMail;
            foundId.ContactInfoMaps = p.ContactInfoMaps;
            foundId.ContactInfoPhone = p.ContactInfoPhone;
            c.SaveChanges();
            return RedirectToAction("ListContact");
        }

        public ActionResult ListAbout()
        {
            var value = c.Abouts.Find(1);
            return View(value);
        }


        [HttpGet]
        public ActionResult EditAbout()
        {
            var foundId = c.Abouts.Find(1);
            return View(foundId);
        }

        [HttpPost]
        public ActionResult EditAbout(About p)
        {
            var foundId = c.Abouts.Find(1);
            foundId.AboutImgUrl1 = p.AboutImgUrl1;
            foundId.AboutTitle1 = p.AboutTitle1;
            foundId.AboutDes1 = p.AboutDes1;

            foundId.AboutTitle2 = p.AboutTitle2;
            foundId.AboutDes2 = p.AboutDes2;

            foundId.AboutImgUrl2 = p.AboutImgUrl2;
            foundId.AboutTitle3 = p.AboutTitle3;
            foundId.AboutDes3 = p.AboutDes3;
            c.SaveChanges();
            return RedirectToAction("ListAbout");
        }





    }
}