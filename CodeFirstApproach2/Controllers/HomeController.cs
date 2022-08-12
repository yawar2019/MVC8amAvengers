using CodeFirstApproach2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModels.Add(emp);//Genereate Insert Query
            int i = db.SaveChanges();//ExecuteNonQuery Method will retun no's of rows effeted return int 
            if (i > 0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            db.Entry(emp).State=EntityState.Modified;//Genereate Update Query
            int i = db.SaveChanges();//ExecuteNonQuery Method will retun no's of rows effeted return int 
            if (i > 0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            db.EmployeeModels.Remove(emp);
            int i = db.SaveChanges();//ExecuteNonQuery Method will retun no's of rows effeted return int 
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View(emp);
        }


    }
}