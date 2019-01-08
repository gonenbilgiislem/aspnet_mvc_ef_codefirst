using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspnet_mvc_ef_codefirst.Models;
using aspnet_mvc_ef_codefirst.Models.Managers;

namespace aspnet_mvc_ef_codefirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            DatabaseContext db = new DatabaseContext();
            List<Kisiler> kisiler = db.Kisiler.ToList();


            return View(kisiler);
        }
    }
}