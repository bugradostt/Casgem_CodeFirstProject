using Casgem_CodeFirstProject.Dal.Context;
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




    }
}