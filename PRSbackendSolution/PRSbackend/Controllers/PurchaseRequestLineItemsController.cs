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
    public class PurchaseRequestLineItemsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: PurchaseRequestLineItems
        public ActionResult Index()
        {
            return View();
        }
        // PurchaseRequestLineItems/List
        public ActionResult List()
        {
            return Json(db.PurchaseRequestLineItems.ToList(), JsonRequestBehavior.AllowGet);
        }
        // PurchaseRequestLineItems/Get/1
        public ActionResult Get(int? id)
        {
            if (id == null)
            {
                return Json(new JsonMessage("Failure", "Id is null"), JsonRequestBehavior.AllowGet);
            }
            PurchaseRequestLineItem purchaserequestlineitem = db.PurchaseRequestLineItems.Find(id);
            if (purchaserequestlineitem == null)
            {
                return Json(new JsonMessage("Failure", "Id is not found"), JsonRequestBehavior.AllowGet);
            }
            return Json(purchaserequestlineitem, JsonRequestBehavior.AllowGet);
        }
        // /PurchaseRequestLineItems/Create/ [POST]
        public ActionResult Create([FromBody] PurchaseRequestLineItem purchaserequestlineitem)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonMessage("Failure", "ModelState is not valid"), JsonRequestBehavior.AllowGet);

            }
            db.PurchaseRequestLineItems.Add(purchaserequestlineitem);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Purchase Request Line Item was created"));
        }
        // /PurchaseRequestLineItems/Change [POST]
        public ActionResult Change([FromBody] PurchaseRequestLineItem purchaserequestlineitem)
        {
            PurchaseRequestLineItem purchaserequestlineitem2 = db.PurchaseRequestLineItems.Find(purchaserequestlineitem.Id);
            if (purchaserequestlineitem2 == null)
            {
                return Json(new JsonMessage("Failure", "Record to be changed has been deleted"));

            }//////////////////////////////////////
            purchaserequestlineitem2.PurchaseRequestId = purchaserequestlineitem.PurchaseRequestId ;
            purchaserequestlineitem2.ProductId = purchaserequestlineitem.ProductId ;
            purchaserequestlineitem2.Quantity = purchaserequestlineitem.Quantity ;
            
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Purchase Request Line Item Request was changed"));
        }


        // /PurchaseRequestLineItems/Remove [POST]
        public ActionResult Remove([FromBody] PurchaseRequestLineItem purchaserequestlineitem)
        {
            PurchaseRequestLineItem purchaserequestlineitem2 = db.PurchaseRequestLineItems.Find(purchaserequestlineitem.Id);
            db.PurchaseRequestLineItems.Remove(purchaserequestlineitem2);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "Purchase Request Line Item was removed"));
        }
    }
}