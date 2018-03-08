using EmployeeWebApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWebApiProject.Controllers
{
    public class EmployeesController : Controller
    {
        private AppDbContext db = new AppDbContext();
            public ActionResult List()
        {
            return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}