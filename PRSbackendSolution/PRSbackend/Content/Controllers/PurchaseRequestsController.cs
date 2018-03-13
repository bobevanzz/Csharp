using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using PRSbackend.Models;
using PRSbackend.Utility;

namespace PRSmaster.Controllers
{
    public class PurchaseRequestsController : Controller
    {
        private AppDbContext db  = new AppDbContext();

        public ActionResult List()
        {
            return new JsonNetResult { Data = db.PurchaseRequests.ToList() };
        }

        public ActionResult Get(int? id)
        {
            if (id == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Id is null" }, JsonRequestBehavior.AllowGet);
            }
            PurchaseRequest purchaseRequest = db.PurchaseRequests.Find(id);
            if (purchaseRequest == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Id not found" }, JsonRequestBehavior.AllowGet);
            }
            return new JsonNetResult { Data = purchaseRequest };
        }
        public ActionResult Add([FromBody] PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest == null || purchaseRequest.Description == null)
            {
                return Json(new Msg { Result = "Failure", Message = "User parameter is missing or invalid" }, JsonRequestBehavior.AllowGet);
            }
            User user = db.Users.Find(purchaseRequest.UserId);
            if (user == null)
            {
                return Json(new Msg { Result = "Failure", Message = "User Id not found" }, JsonRequestBehavior.AllowGet);
            }

            db.PurchaseRequests.Add(purchaseRequest);
            db.SaveChanges();

            return Json(new Msg { Result = "Success", Message = "Add successful" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Change([FromBody] PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Purchase request  is null" }, JsonRequestBehavior.AllowGet);
            }
            User user = db.Users.Find(purchaseRequest.UserId);
            if (user == null)
            {
                return Json(new Msg { Result = "Failure", Message = "User Id FK is invalid" }, JsonRequestBehavior.AllowGet);
            }

            PurchaseRequest tempPurchaseRequest = db.PurchaseRequests.Find(purchaseRequest.Id);
            if (tempPurchaseRequest == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Purchase request Id not found" }, JsonRequestBehavior.AllowGet);
            }
            tempPurchaseRequest.Clone(purchaseRequest);
            db.SaveChanges();
            return Json(new Msg { Result = "Success", Message = "Change Successful." }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Remove([FromBody] PurchaseRequest purchaseRequest)
        {
            if (purchaseRequest == null || purchaseRequest.Id <= 0)
            {
                return Json(new Msg { Result = "Failure", Message = "User parameter is missing or invalid" }, JsonRequestBehavior.AllowGet);
            }
            PurchaseRequest tempPurchaseRequest = db.PurchaseRequests.Find(purchaseRequest.Id);
            if (tempPurchaseRequest == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Purchase ID not found." }, JsonRequestBehavior.AllowGet);
            }
            db.PurchaseRequests.Remove(tempPurchaseRequest);
            db.SaveChanges();
            return Json(new Msg { Result = "Success", Message = "Change Successful." });
        }

        public ActionResult Review()
        {
            var purchaseRequests = db.PurchaseRequests.Where(pr => pr.Status == "REVIEW");
            return new JsonNetResult { Data = purchaseRequests.ToList() };
        }
    }
}

