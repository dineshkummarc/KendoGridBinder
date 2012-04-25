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
        public ActionResult Index2()
        {
            return View();
        }
        private static IEnumerable<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee{EmployeeId = 1,EmployeeNumber = 1, HireDate = new DateTime(2010, 1, 1),Active = true, Name = "Bill Jones",Email = "bill@email.com"},
                new Employee{EmployeeId = 2,EmployeeNumber = 2, HireDate = new DateTime(2010, 2, 1),Active = false,Name = "Rob Johnson",Email = "rob@email.com"},
                new Employee{EmployeeId = 3,EmployeeNumber = 3, HireDate = new DateTime(2010, 3, 1),Active = true, Name = "Jane Smith",Email = "jane@email.com"},
                new Employee{EmployeeId = 4,EmployeeNumber = 4, HireDate = new DateTime(2010, 4, 1),Active = false,Name = "Homer Simpson",Email = "homer@email.com"},
                new Employee{EmployeeId = 5,EmployeeNumber = 5, HireDate = new DateTime(2010, 5, 1),Active = true, Name = "Joe Dugan",Email = "joe@email.com"},
                new Employee{EmployeeId = 6,EmployeeNumber = 6, HireDate = new DateTime(2010, 7, 1),Active = true, Name = "Eric Rammy",Email = "eric@email.com"},
                new Employee{EmployeeId = 7,EmployeeNumber = 7, HireDate = new DateTime(2010, 8, 1),Active = true, Name = "Wetzl Dugan",Email = "wetz@email.com"},
            };
            return employees;
        }


        [HttpPost]
        public JsonResult Grid2(KendoGridRequest request)
        {

            var employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, HireDate = new DateTime(2012, 1, 13),  FirstName = "Bill", LastName = "Jones", Email = "bill@email.com" },
                new Employee { EmployeeId = 2, HireDate = new DateTime(2012, 2, 16),  FirstName = "Rob", LastName = "aaaaaa", Email = "rob@email.com" },
                new Employee { EmployeeId = 3, HireDate = new DateTime(2012, 3, 14),  FirstName = "Jane", LastName = "ssss", Email = "jane@email.com" },
                new Employee { EmployeeId = 4, HireDate = new DateTime(2012, 4, 12),  FirstName = "bbb", LastName = "ggg", Email = "jane@email.com" },
                new Employee { EmployeeId = 5, HireDate = new DateTime(2012, 5, 1),   FirstName = "cccc", LastName = "ff", Email = "jane@email.com" },
                new Employee { EmployeeId = 6, HireDate = new DateTime(2012, 7, 12),  FirstName = "dddd", LastName = "eeee", Email = "jane@email.com" },
            };

            var grid = new KendoGrid<Employee>(request, employees);
            return Json(grid);
        }


        [HttpPost]
        public JsonResult Grid(KendoGridRequest request)
        {

            var employees = new List<Employee>
            {
                new Employee { EmployeeId = 1, HireDate = new DateTime(2010, 1, 13), FirstName = "Bill", LastName = "Jones", Email = "bill@email.com" },
                new Employee { EmployeeId = 2, HireDate = new DateTime(2010, 2, 16), FirstName = "Rob", LastName = "aaaaaa", Email = "aaaa@email.com" },
                new Employee { EmployeeId = 3, HireDate = new DateTime(2010, 3, 14), FirstName = "Jane", LastName = "ssss", Email = "sssss@email.com" },
                new Employee { EmployeeId = 4, HireDate = new DateTime(2010, 4, 12), FirstName = "bbb", LastName = "ggg", Email = "gggg@email.com" },
                new Employee { EmployeeId = 5, HireDate = new DateTime(2010, 5, 1),  FirstName = "cccc", LastName = "ff", Email = "ff@email.com" },
                new Employee { EmployeeId = 6, HireDate = new DateTime(2010, 7, 12), FirstName = "dddd", LastName = "eeee", Email = "eeee@email.com" },
            };                               

            var grid = new KendoGrid<Employee>(request, employees);
            return Json(grid);
        }

        [HttpPost]
        public JsonResult Export(KendoGridRequest request)
        {
            var employees = GetEmployees();

            var grid = new KendoGrid<Employee>(request, employees);
            return Json(grid);
        }

    }
}
