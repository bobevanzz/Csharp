using PRSbackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PRSbackend.Utility;
using System.Web.Mvc;
using System.Web.Http;

namespace PRSbackend.Controllers
{
    public class UsersController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        // Users/List
        public ActionResult List()
        {
            return Json(db.Users.ToList(), JsonRequestBehavior.AllowGet);
        }
        // Users/Get/1
        public ActionResult Get(int? id)
        {
            if (id == null)
            {
                return Json(new JsonMessage("Failure", "Id is null"), JsonRequestBehavior.AllowGet);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return Json(new JsonMessage("Failure", "Id is not found"), JsonRequestBehavior.AllowGet);
            }
            return Json(user, JsonRequestBehavior.AllowGet);
        }
        // /Users/Create/ [POST]
        public ActionResult Create([FromBody] User user)

        {
            user.DateCreated = DateTime.Now;
            if (!ModelState.IsValid)
            {
                return Json(new JsonMessage("Failure", "ModelState is not valid"), JsonRequestBehavior.AllowGet);

            }
            db.Users.Add(user);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "User was created"));
        }
        // /Users/Change [POST]
        public ActionResult Change([FromBody] User user)
        {
            User user2 = db.Users.Find(user.Id);
            if (user2 == null)
            {
                return Json(new JsonMessage("Failure", "Record to be changed has been deleted"));

            }
            user2.UserName = user.UserName;
            user2.Password = user.Password;
            user2.FirstName = user.FirstName;
            user2.LastName = user.LastName;
            user2.Phone = user.Phone;
            user2.Email = user.Email;
            user2.IsReviewer = user.IsReviewer;
            user2.IsAdmin = user.IsAdmin;
            user2.Active = user.Active;
            user2.DateCreated = user.DateCreated;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "User was changed"));
        }


        // /Users/Remove [POST]
        public ActionResult Remove([FromBody] User user)
        {
            User user2 = db.Users.Find(user.Id);
            db.Users.Remove(user2);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return Json(new JsonMessage("Failure", ex.Message), JsonRequestBehavior.AllowGet);
            }
            return Json(new JsonMessage("Success", "User was removed"));
        }
    }
}