using MVCGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGrid.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities _northwindEntities;
        public HomeController()
        {
            _northwindEntities = new NorthwindEntities();
        }
        public ActionResult Index()
        {   
            var model = _northwindEntities.Categories.ToList();
            return View(model);
        }

    }
}