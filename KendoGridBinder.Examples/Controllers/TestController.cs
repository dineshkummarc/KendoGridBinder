using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoGridBinder.Examples.Models;

namespace KendoGridBinder.Examples.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public JsonResult Grid(KendoGridRequest request)
        {
            var employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, HireDate = new DateTime(2010, 1, 1) ,Name = "Bill Jones", Email = "bill@email.com" },
                new Employee { EmployeeId = 2, HireDate = new DateTime(2010, 2, 1) ,Name = "Rob Johnson", Email = "rob@email.com" },
                new Employee { EmployeeId = 3, HireDate = new DateTime(2010, 3, 1) ,Name = "Jane Smith", Email = "jane@email.com" },
                new Employee { EmployeeId = 4, HireDate = new DateTime(2010, 4, 1) ,Name = "Homer Simpson", Email = "homer@email.com" },
                new Employee { EmployeeId = 5, HireDate = new DateTime(2010, 5, 1) ,Name = "Joe Dugan", Email = "joe@email.com" },
                new Employee { EmployeeId = 6, HireDate = new DateTime(2010, 7, 1) ,Name = "Eric Rammy", Email = "eric@email.com" },
                new Employee { EmployeeId = 7, HireDate = new DateTime(2010, 8, 1) ,Name = "Wetzl Dugan", Email = "wetz@email.com" },
            };

            var grid = new KendoGrid<Employee>(request, employees);
            return Json(grid);
        }



    }
}
