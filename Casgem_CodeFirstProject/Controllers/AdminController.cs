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




    }
}