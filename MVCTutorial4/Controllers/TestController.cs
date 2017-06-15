using MVCTutorial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCTutorial4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            MVCTutorial2Entities db = new MVCTutorial2Entities();
            List<Department> list = db.Departments.ToList();

            //List<Employee> l = db.Employees.ToList();
            //ViewBag.EmployeeList = new SelectList(l, "EmployeeId", "Emri");


            ViewBag.DepartmentList = new SelectList(list, "DepartmentId", "DepartmentName");
            return View();
        }
        public ActionResult SaveRecord(EmployeeViewModel model)
        {
            try {
                MVCTutorial2Entities db = new MVCTutorial2Entities();
                Employee emp = new Employee();
                emp.EmployeeId = model.EmployeeId;
                emp.Emri = model.Emri;
                emp.Address = model.Address;
                emp.DepartmentId = model.DepartmentId;
                db.Employees.Add(emp);
                db.SaveChanges();
                int lastEmployeeId = emp.EmployeeId;

            } catch (Exception ex){
                throw ex;
            }
           
            return RedirectToAction("Index");
        }
    }
}