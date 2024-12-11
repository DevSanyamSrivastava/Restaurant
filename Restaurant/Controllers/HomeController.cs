using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        //mywebEntities con = new mywebEntities();
        public ActionResult Index()
        {
            return View();
        }
         public ActionResult Menu()
        {
            return View();
        }
             public ActionResult Catering()
        {
            return View();
        }

        public ActionResult Galley()
        {
            return View();
        }
        public ActionResult Feedback()
        {
            return View();
        }

    
    }




}
