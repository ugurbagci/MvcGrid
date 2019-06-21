using MVCGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGrid.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities _northwindEntities;
        public ProductController()
        {
            _northwindEntities = new NorthwindEntities();
        }
        public ActionResult Index()
        {
            var model = _northwindEntities.Products.Join( )Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.Category.CategoryID,
                x.Category.CategoryName,
                x.Category.Description          
            }).ToList();           
    // burada kaldık bee            
                
           return View(model);
        }
    }
}