using PRSbackend.Models;
using PRSbackend.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace PRSbackend.Controllers
{
    public class PurchaseRequestsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: PurchaseRequests
        public ActionResult Index()
        {
            return View();
        }
        // PurchaseRequests/List
        public ActionResult List()
        {
            return Json(db.PurchaseRequests.ToList(), JsonRequestBehavior.AllowGet);
        }
        // PurchaseRequests/Get/1
        public ActionResult Get(int? id)
        {
            if (id == null)
            {
                return Json(new JsonMessage("Failure", "Id is null"), JsonRequestBehavior.AllowGet);
            }
            PurchaseRequest purchaserequest = db.PurchaseRequests.Find(id);
            if (purchaserequest == null)
            {
                return Json(new JsonMessage("Failure", "Id is not found"), JsonRequestBehavior.AllowGet);
            }
            return Json(purchaserequest, JsonRequestBehavior.AllowGet);
        }
        // /PurchaseRequests/Create/ [POST]
        public ActionResult Create([FromBody] PurchaseRequest purchaserequest)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonMessage("Failure", "ModelState is not valid"), JsonRequestBehavior.AllowGet);

            }
            db.PurchaseRequests.Add(purchaserequest);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "PurchaseRequest was created"));
        }
        // /PurchaseRequests/Change [POST]
        public ActionResult Change([FromBody] PurchaseRequest purchaserequest)
        {
            PurchaseRequest purchaserequest2 = db.PurchaseRequests.Find(purchaserequest.Id);
            if (purchaserequest2 == null)
            {
                return Json(new JsonMessage("Failure", "Record to be changed has been deleted"));

            }//////////////////////////////
            purchaserequest2.UserId = purchaserequest.UserId;
            purchaserequest2.Description = purchaserequest.Description;
            purchaserequest2.Justification = purchaserequest.Justification;
            purchaserequest2.DeliveryMode = purchaserequest.DeliveryMode;
            purchaserequest2.Status = purchaserequest.Status;
            purchaserequest2.Total = purchaserequest.Total;
            purchaserequest2.Active = purchaserequest.Active;
            purchaserequest2.ReasonForRejection = purchaserequest.ReasonForRejection;
            purchaserequest.DateCreated = purchaserequest.DateCreated; 
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Purchase Request was changed"));
        }


        // /PurchaseRequests/Remove [POST]
        public ActionResult Remove([FromBody] PurchaseRequest purchaserequest)
        {
            PurchaseRequest purchaserequest2 = db.PurchaseRequests.Find(purchaserequest.Id);
            db.PurchaseRequests.Remove(purchaserequest2);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Purchase Request was removed"));
        }
    }
}