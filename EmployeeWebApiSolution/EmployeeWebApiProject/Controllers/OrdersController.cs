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
    public class OrdersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        // Orders/List
        public ActionResult List()
        {
            return Json(db.Orders.ToList(), JsonRequestBehavior.AllowGet);
        }
        // Orders/Get/1
        public ActionResult Get(int? id)
        {
            if (id == null)
            {
                return Json(new JsonMessage("Failure", "Id is null"), JsonRequestBehavior.AllowGet);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return Json(new JsonMessage("Failure", "Id is not found"), JsonRequestBehavior.AllowGet);
            }
            return Json(order, JsonRequestBehavior.AllowGet);
        }
        // /Orders/Create/ [POST]
        public ActionResult Create([FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonMessage("Failure", "ModelState is not valid"), JsonRequestBehavior.AllowGet);

            }
            db.Orders.Add(order);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Order was created"));
        }
        // /Orders/Change [POST]
        public ActionResult Change([FromBody] Order order)
        {
            Order order2 = db.Orders.Find(order.Id);
            if (order2 == null)
            {
                return Json(new JsonMessage("Failure", "Record to be changed has been deleted"));

            }
            order2.Description = order.Description;
            order2.Total = order.Total;
            order2.Fulfilled = order.Fulfilled;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Order was changed"));
        }


        // /Orders/Remove [POST]
        public ActionResult Remove([FromBody] Order order)
        {
            Order order2 = db.Orders.Find(order.Id);
            db.Orders.Remove(order2);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Order was removed"));
        }
        
    }
}