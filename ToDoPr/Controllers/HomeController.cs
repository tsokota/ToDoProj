using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoPr.Models;

namespace ToDoPr.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db = new TaskContext();

        public ActionResult Index()
        {
            return View(db.Tasks);
        }

       
        public ActionResult Delete(int id)
        {
            Task userprofile = db.Tasks.Find(id);
            if (userprofile != null)
            {
                db.Tasks.Remove(userprofile);
                db.SaveChanges();
            }
            return PartialView(db.Tasks);
        }


        public ActionResult Delete1(int id)
        {
            Task userprofile = db.Tasks.Find(id);
            if (userprofile != null)
            {
                db.Tasks.Remove(userprofile);
                db.SaveChanges();
            }
            return Redirect("/Home/Index");
        }

    }
}