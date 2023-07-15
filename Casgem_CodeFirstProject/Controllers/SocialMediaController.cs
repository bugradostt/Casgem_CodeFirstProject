using Casgem_CodeFirstProject.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia

        TravelContext c = new TravelContext();

        public ActionResult Index()
        {
            var values = c.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            List<SelectListItem> values = (from x in c.Guides.ToList()
                                           select new SelectListItem
                                           {
                                               Value = x.GuideId.ToString(),
                                               Text = x.GuideName
                                           }
                                          ).ToList();
            ViewBag.v = values;
            return View();
        }
    }
}