using Casgem_CodeFirstProject.Dal.Context;
using Casgem_CodeFirstProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminGuideController : Controller
    {
        // GET: AdminGuide

        TravelContext c = new TravelContext();
        public ActionResult Index()
        {
            var values = c.Guides.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGuide(Guide p)
        {
            c.Guides.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteGuide(int id)
        {
            var foundId = c.Guides.Find(id);
            c.Guides.Remove(foundId);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditGuide(int id)
        {
            var foundId = c.Guides.Find(id);
            return View(foundId);
        }

        [HttpPost]
        public ActionResult EditGuide(Guide p)
        {
            var foundId = c.Guides.Find(p.GuideId);
            foundId.GuideImageUrl = p.GuideImageUrl;
            foundId.GuideName = p.GuideName;
            foundId.GuideTitle = p.GuideTitle;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}