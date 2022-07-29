using Mvc8amAvengersTeam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc8amAvengersTeam.Controllers
{
    public class NewController : Controller
    {
        // GET: New usha
        //[NonAction]
        public string Index()
        {
            return "hello";
        }

        public ActionResult GetMeView()
        {
            string a = Index();
            ViewBag.info =a;
            return View();
        }
        //controller/action/eid
        [Route("student/Arpita")]
        [Route("student/priya")]
        [Route("new/test")]
        public string test(int? id)
        {
            return "My Employee id is "+id+" Name is "+Request.QueryString["name"]+ "Designation is "+Request.QueryString["Designation"];
        }

        public ActionResult getSomeData()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            ViewBag.empinfo = emp;

            return View();
        }

        public ActionResult getSomeData2()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);

            ViewBag.Emp = listEmployee;


            return View();
        }

        public ActionResult getSomeData3()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;
            string a = "asdf";
            String b = "asdfs";

            //object model = emp;
            return View(emp);
        }

        public ActionResult getSomeData4()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);

           


            return View(listEmployee);
        }

        public ActionResult getSomeData5()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);


            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1211;
            dept1.DeptName = "IT";

            DepartmentModel dept2 = new DepartmentModel();
            dept2.DeptId = 1212;
            dept2.DeptName = "Marketing";

            List<DepartmentModel> listDept = new List<Models.DepartmentModel>();
            listDept.Add(dept1);
            listDept.Add(dept2);


            EmpDept ed = new EmpDept();
            ed.emp = listEmployee;
            ed.dept = listDept;
            

            return View(ed);
        }

        public RedirectResult GetmeSampleView()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult GetmeSampleView2()
        {
            return Redirect("~/new/getSomeData5");
        }

        public ActionResult getSomePartialView()
        {
            return View();
        }

        public ActionResult getSomePartialView2()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);
            
            return View(listEmployee);

        }

        public ActionResult getDirectPv()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);

            return PartialView("_MyEmployeeListPartialView", listEmployee);
        }

         public ActionResult GetMyView()
        {
            return View("getmeView");
        }

        public ActionResult GetMyView2()
        {
            return View("~/Views/Default/Index.cshtml");
        }

        public RedirectToRouteResult GetMyView3()
        {
            return RedirectToAction("Index","Default",new {id=1});
        }

        public RedirectToRouteResult GetMyView4()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);

            return RedirectToAction("Index2", "Default", listEmployee);
        }

        public EmptyResult ExecuteLogic()
        {
            ///logic 
            return new EmptyResult();
        }

        public JsonResult GetjsonData()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);


            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1211;
            dept1.DeptName = "IT";

            DepartmentModel dept2 = new DepartmentModel();
            dept2.DeptId = 1212;
            dept2.DeptName = "Marketing";

            List<DepartmentModel> listDept = new List<Models.DepartmentModel>();
            listDept.Add(dept1);
            listDept.Add(dept2);

             
            EmpDept ed = new EmpDept();
            ed.emp = listEmployee;
            ed.dept = listDept;
            return Json(ed, JsonRequestBehavior.AllowGet);
        }

        
        public JsonResult GetjsonData2()
        {
            List<EmployeeModel> listEmployee = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Radha";
            emp.EmpSalary = 700000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Johny";
            emp1.EmpSalary = 900000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "James";
            emp2.EmpSalary = 600000;

            listEmployee.Add(emp);
            listEmployee.Add(emp1);
            listEmployee.Add(emp2);


 
            return Json(listEmployee, JsonRequestBehavior.AllowGet);
        }

        public ViewResult GetjsonResultInView()
        {
            return View();
        }

        public FileResult GetFileData()
        {
            return File("~/Web.config","text");
        }
        public FileResult GetFileData2()
        {
            return File("~/Web.config", "application/xml");
        }
        public FileResult GetFileData3()
        {
            return File("~/Notes/ActionResult.pdf", "application/pdf");
        }
        public FileResult GetFileData4()
        {
            return File("~/Notes/ActionResult.pdf", "application/pdf", "ActionResult.pdf");
        }

        public ContentResult GetContent(int? id)
        {
            if(id==1)
            {
                return Content("Hello World");
            }
            else if (id == 2)
            {
                return Content("<p style='color:red'>Hello World</p>");
            }
            else
            {
                return Content("<script> alert('Hello World')</script>");

            }
        }
    }
}