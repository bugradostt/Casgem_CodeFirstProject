﻿using Casgem_CodeFirstProject.Dal.Context;
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
            var values = c.Sliders.OrderByDescending(x => x.SliderId).ToList();
           return PartialView(values);
        }

        public PartialViewResult _PartialBooking()
        {
            //var values = c.Destinations.Select(x => x.DestinationName).ToList();

            var values = c.Destinations.OrderBy(x=>x.DestinationName).ToList();
            return PartialView(values);
        }

        [HttpPost]
        public ActionResult AddBooking(Booking p)
        {
            c.Bookings.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public PartialViewResult _PartialFooter()
        {
            var values = c.ContactInfos.ToList();
            return PartialView(values);
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

        public PartialViewResult _PartialAboutUser()
        {
            var values = c.Guides.OrderByDescending(x=>x.GuideId).ToList();
            return PartialView(values);
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