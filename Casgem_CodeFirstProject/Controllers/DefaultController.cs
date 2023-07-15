using Casgem_CodeFirstProject.Dal.Context;
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
    }
}