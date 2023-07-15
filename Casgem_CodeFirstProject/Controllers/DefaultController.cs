using Casgem_CodeFirstProject.Dal.Context;
using Casgem_CodeFirstProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {

        TravelContext c = new TravelContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult _PartialJavascript()
        {
            return PartialView();
        }

        public PartialViewResult _PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult _PartialSlider()
        {
            return PartialView();
        }

        public PartialViewResult _PartialBooking()
        {
            return PartialView();
        }

        public PartialViewResult _PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult _PartialMoveTop()
        {
            return PartialView();
        }

        public PartialViewResult _PartialDestinations()
        {
            var values = c.Destinations.ToList();
            return PartialView(values);
        }

        public ActionResult About()
        {
            var value = c.Abouts.Find(1);
            return View(value);
        }

        [HttpGet]
        public ActionResult Contact()
        {
            var value = c.ContactInfos.Find(1);
            return View(value);
        }

        [HttpPost]
        public ActionResult Contact(Contact p)
        {
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            c.Contacts.Add(p);
            c.SaveChanges();
            return RedirectToAction("Contact");
        }
    }
}