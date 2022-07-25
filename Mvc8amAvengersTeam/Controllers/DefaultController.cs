using Mvc8amAvengersTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc8amAvengersTeam.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? id)
        {
            ViewBag.info = "Hello World"+ id;
            return View();
        }

        public ActionResult Index2(List<EmployeeModel> emp)
        {
            return Content("the Employee Name is Priya");
        }
    }
}