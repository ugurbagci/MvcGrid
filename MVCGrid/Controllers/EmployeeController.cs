using MVCGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGrid.Controllers
{
    public class EmployeeController : Controller
    {
        NorthwindEntities _northwindEntities;
        public EmployeeController()
        {
            _northwindEntities = new NorthwindEntities();
        }
        public ActionResult Index()
        {
            var model = _northwindEntities.Employees.ToList();
            return View(model);
        }
    }
}