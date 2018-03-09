using EmployeeWebApiProject.Models;
using EmployeeWebApiProject.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EmployeeWebApiProject.Controllers
{
    public class CustomersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        // Customers/List
        public ActionResult List()
        {
            return Json(db.Customers.ToList(), JsonRequestBehavior.AllowGet);
        }
        // Customers/Get/1
        public ActionResult Get(int? id)
        {
            if (id == null)
            {
                return Json(new JsonMessage("Failure", "Id is null"), JsonRequestBehavior.AllowGet);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return Json(new JsonMessage("Failure", "Id is not found"), JsonRequestBehavior.AllowGet);
            }
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
        // /Customers/Create/ [POST]
        public ActionResult Create([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonMessage("Failure", "ModelState is not valid"), JsonRequestBehavior.AllowGet);

            }
            db.Customers.Add(customer);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Customer was created"));
        }
        // /Customers/Change [POST]
        public ActionResult Change([FromBody] Customer customer)
        {
            Customer customer2 = db.Customers.Find(customer.Id);
            if (customer2 == null)
            {
                return Json(new JsonMessage("Failure", "Record to be changed has been deleted"));

            }
            customer2.Name = customer.Name;
            customer2.CreditLimit = customer.CreditLimit;
            customer2.Active = customer.Active;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Customer was changed"));
        }


        // /Customers/Remove [POST]
        public ActionResult Remove([FromBody] Customer customer)
        {
            Customer customer2 = db.Customers.Find(customer.Id);
            db.Customers.Remove(customer2);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Customer was removed"));
        }
    }
}
