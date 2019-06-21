using MVCGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGrid.Controllers
{
    public class CategoryController : Controller
    {
     
        NorthwindEntities _northwindEntities;
        public CategoryController()
        {
            _northwindEntities = new NorthwindEntities();
        }
        public ActionResult Index()
        {
            var model = _northwindEntities.Products.Where(x => x.CategoryID == 8).ToList();

            return View(model);
        }
    }
}