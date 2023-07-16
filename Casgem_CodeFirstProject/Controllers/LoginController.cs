using Casgem_CodeFirstProject.Dal.Context;
using Casgem_CodeFirstProject.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Casgem_CodeFirstProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        TravelContext c = new TravelContext();


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var values = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword && x.AdminStatus==true);

            if(values != null)
            {
                FormsAuthentication.SetAuthCookie(values.AdminUserName, false);
              Session["userTravel"] = values.AdminUserName.ToString();
              return RedirectToAction("ListSlider", "Admin");
            
            }
            else
            {
                return View();
            }


        }

        [HttpGet]
        public ActionResult Uye()
        {
            return View();
        }

        public ActionResult LogOut()
        {

            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index");
        }


    }
}