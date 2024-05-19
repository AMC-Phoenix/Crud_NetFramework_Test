using CrudApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudApplication.Controllers
{
    public class HomeController : Controller
    {
            EmployeeDB empDB = new EmployeeDB();
            // GET: Home
            public ActionResult Index()
            {
                return View();
            }
            public JsonResult List() {//Load data function from employee.js is sending the request here
                return Json(empDB.ListAll(), JsonRequestBehavior.AllowGet);
            }
            public JsonResult Add(Employee emp)
            {
            return Json(empDB.Add(emp), JsonRequestBehavior.AllowGet);
            }
            public JsonResult GetbyID(int ID)
            {
                var Employee = empDB.ListAll().Find(x => x.EmployeeID.Equals(ID));
                return Json(Employee, JsonRequestBehavior.AllowGet);
            }
            public JsonResult Update(Employee emp)
            {
                return Json(empDB.Update(emp), JsonRequestBehavior.AllowGet);
            }
            public JsonResult Delete(int ID)
            {
                return Json(empDB.Delete(ID), JsonRequestBehavior.AllowGet);
            }
        
    }
}