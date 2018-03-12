using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRSmaster.Models;
using System.Web.Http;
using Utility;

namespace PRSmaster.Controllers
{
    public class ProductsController : Controller
    {
        private PRSwebContext db = new PRSwebContext();

        public ActionResult List() 
        {
            return Json(db.Products.ToList(), JsonRequestBehavior.AllowGet);

        }

        public ActionResult Get(int? id)
        {
            if (id == null) 
            {
                return Json(new Msg { Result = "Failure", Message = "Id is null" }, JsonRequestBehavior.AllowGet);
            }
            Product product = db.Products.Find(id); 
            if (product == null) 
            {
                return Json(new Msg { Result = "Failure", Message = "Id not found" }, JsonRequestBehavior.AllowGet);
            }
            return Json(product, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Add([FromBody] Product product) 
        {
            if (product == null || product.PartNumber == null) 
            {
                return Json(new Msg { Result = "Failure", Message = "User parameter is missing or invalid" });
            }
            
            Vendor vendor = db.Vendors.Find(product.VendorId); 
            if (vendor == null) 
            {
                return Json(new Msg { Result = "Failure", Message = "Vendor Id not found" });
            }
            
            db.Products.Add(product);
            db.SaveChanges(); 
            return Json(new Msg { Result = "Success", Message = "Add successful" });
        }
        public ActionResult Change([FromBody] Product product)
        {
            if (product == null || product.PartNumber == null)
            {
                return Json(new Msg { Result = "Failure", Message = "Vendor parameter is missing or invalid" });
            }
            Vendor vendor = db.Vendors.Find(product.VendorId); 
            if (vendor == null) 
            {
                return Json(new Msg { Result = "Failure", Message = "Vendor Id not found" });
            }
            
            Product tempProduct = db.Products.Find(product.Id);
            tempProduct.PartNumber = product.PartNumber;
            tempProduct.Name = product.Name;
            tempProduct.Price = product.Price;
            tempProduct.Unit = product.Unit;
            tempProduct.PhotoPath = product.PhotoPath;
            tempProduct.Active = product.Active;
            tempProduct.DateCreated = product.DateCreated;
            tempProduct.VendorId = product.VendorId;
            db.SaveChanges(); 
            return Json(new Msg { Result = "Success", Message = "Change Successful." });
        }

        public ActionResult Remove([FromBody] Product product)
        {
            if (product == null || product.Id <= 0)
            {
                return Json(new Msg { Result = "Failure", Message = "User parameter is missing or invalid" });
            }
            Product tempProduct = db.Products.Find(product.Id);
            if (tempProduct == null) 
            {
                return Json(new Msg { Result = "Failure", Message = "Product ID not found." });
            }
            db.Products.Remove(tempProduct); 
            db.SaveChanges();
            return Json(new Msg { Result = "Success", Message = "Change Successful." });
        }


        #region MVC Methods
        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Vendor);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "Code");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VendorPartNumber,Name,Price,Unit,PhotoPath,VendorId")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "Code", product.VendorId);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "Code", product.VendorId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VendorPartNumber,Name,Price,Unit,PhotoPath,VendorId")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "Code", product.VendorId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
#endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
