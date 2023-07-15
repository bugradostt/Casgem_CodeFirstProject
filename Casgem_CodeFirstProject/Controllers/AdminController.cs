using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminController : Controller
    {
        Context c new 
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }


    }
}