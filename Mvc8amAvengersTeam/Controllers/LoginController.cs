using Mvc8amAvengersTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc8amAvengersTeam.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        EmployeeEntities db = new Models.EmployeeEntities();

        // GET: Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            var Reguser = db.UserDetails.Where(x => x.UserName == user.UserName && x.Password == user.Password).SingleOrDefault();

            if(Reguser!=null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return Redirect("~/Login/Dashboard");
            }
                return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login/Login");
        }

        [Authorize(Roles="Admin")]
        public ActionResult ContactUs()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}