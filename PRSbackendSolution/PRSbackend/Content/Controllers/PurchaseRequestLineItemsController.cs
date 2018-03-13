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

        struct prliType
        {
            public PurchaseRequest PurchaseRequest;
            public IEnumerable<PurchaseRequestLineItem> PurchaseRequestLineItems;
        }
        private void UpdatePurchaseRequestTotal(int prid)
        {
            decimal total = 0.0m;
            var purchaseRequestLineItems = db.PurchaseRequestLineItems.Where(p => p.PurchaseRequestId == prid);
            foreach (var purchaseRequestLineItem in purchaseRequestLineItems)
            {
                var subTotal = purchaseRequestLineItem.Quantity * purchaseRequestLineItem.Product.Price;
                total += subTotal;
            }
            var purchaseRequest = db.PurchaseRequests.Find(prid);
            purchaseRequest.Total = total;
            db.SaveChanges();
        }
        public ActionResult List()
        {
            return Json(db.PurchaseRequests.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Get(int? id)
        {
            if (id == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Id is null" }, JsonRequestBehavior.AllowGet);
            }
            PurchaseRequestLineItem purchaseRequestLineItem = db.PurchaseRequestLineItems.Find(id);
            if (purchaseRequestLineItem == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Id not found" }, JsonRequestBehavior.AllowGet);
            }
            return Json(purchaseRequestLineItem, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Add([FromBody] PurchaseRequestLineItem purchaseRequestLineItem)
        {
            if (purchaseRequestLineItem == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Parameter is missing or invalid" }, JsonRequestBehavior.AllowGet);
            }
            PurchaseRequest purchaseRequest = db.PurchaseRequests.Find(purchaseRequestLineItem.PurchaseRequestId);
            if (purchaseRequest == null)
            {
                return Json(new Msg { Result = "Failure", Message = "PurchaseRequest Id not found" }, JsonRequestBehavior.AllowGet);
            }
            Product product = db.Products.Find(purchaseRequestLineItem.ProductId);
            if (product == null)
            {
                return Json(new Msg { Result = "Failure", Message = "ProductId not found" }, JsonRequestBehavior.AllowGet);
            }
            db.PurchaseRequestLineItems.Add(purchaseRequestLineItem);
            db.SaveChanges();
            UpdatePurchaseRequestTotal(purchaseRequestLineItem.PurchaseRequestId);
            return Json(new Msg { Result = "Success", Message = "Add successful" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Change([FromBody] PurchaseRequestLineItem purchaseRequestLineItem)
        {
            if (purchaseRequestLineItem == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Purchase request  is null" }, JsonRequestBehavior.AllowGet);
            }
            PurchaseRequest purchaseRequest = db.PurchaseRequests.Find(purchaseRequestLineItem.PurchaseRequestId);
            if (purchaseRequest == null)
            {
                return Json(new Msg { Result = "Failure", Message = "PurchaseRequest Id not found" }, JsonRequestBehavior.AllowGet);
            }

            Product product = db.Products.Find(purchaseRequestLineItem.ProductId);
            if (product == null)
            {
                return Json(new Msg { Result = "Failure", Message = "ProductId not found" }, JsonRequestBehavior.AllowGet);
            }

            if (purchaseRequestLineItem.Quantity < 0)
            {
                return Json(new Msg { Result = "Failure", Message = "Quantity is invalid" }, JsonRequestBehavior.AllowGet);
            }

            var tempPurchaseRequestLineItem = db.PurchaseRequestLineItems.Find(purchaseRequestLineItem.Id);
            if (tempPurchaseRequestLineItem == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Purchase Request Line Item Id not found" }, JsonRequestBehavior.AllowGet);
            }

            tempPurchaseRequestLineItem.Quantity = purchaseRequestLineItem.Quantity;
            tempPurchaseRequestLineItem.ProductId = purchaseRequestLineItem.ProductId;
            tempPurchaseRequestLineItem.PurchaseRequestId = purchaseRequestLineItem.PurchaseRequestId;

            db.SaveChanges();
            UpdatePurchaseRequestTotal(purchaseRequestLineItem.PurchaseRequestId);
            return Json(new Msg { Result = "Success", Message = "Add successful" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Remove([FromBody] PurchaseRequestLineItem purchaseRequestLineItem)
        {
            if (purchaseRequestLineItem == null || purchaseRequestLineItem.Id <= 0)
            {
                return Json(new Msg { Result = "Failure", Message = "User parameter is missing or invalid" }, JsonRequestBehavior.AllowGet);
            }
            PurchaseRequestLineItem tempPurchaseRequestLineItem = db.PurchaseRequestLineItems.Find(purchaseRequestLineItem.Id);
            if (tempPurchaseRequestLineItem == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Purchase ID not found." }, JsonRequestBehavior.AllowGet);
            }
            db.PurchaseRequestLineItems.Remove(tempPurchaseRequestLineItem);
            db.SaveChanges();
            UpdatePurchaseRequestTotal(tempPurchaseRequestLineItem.PurchaseRequestId);
            return Json(new Msg { Result = "Success", Message = "Change Successful." });
        }

        public ActionResult GetByPurchaseRequestId(int? id)
        {
            if (id == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Id is null" }, JsonRequestBehavior.AllowGet);
            }

            var purchaseRequest = db.PurchaseRequests.Find(id);

            if (purchaseRequest == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Purchase Request Id not found" }, JsonRequestBehavior.AllowGet);
            }

            var purchaseRequestLineItems = db.PurchaseRequestLineItems.Where(pr => pr.PurchaseRequestId == purchaseRequest.Id);

            var prl = new prliType { PurchaseRequest = purchaseRequest, PurchaseRequestLineItems = purchaseRequestLineItems };
            return new JsonNetResult { Data = prl };
        }
    }
}