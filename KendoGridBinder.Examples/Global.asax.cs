using System.Collections.Generic;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KendoGridBinder.Examples.Models;
using System;

namespace KendoGridBinder.Examples
{
    public class MvcApplication : HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Inline", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }



        protected void Session_Start(Object sender, EventArgs e)
        { 
            //var employees = new List<Employee>
            //{
            //    new Employee { EmployeeId = 1, HireDate = new DateTime(2012, 1, 13),  FirstName = "Bill", LastName = "Jones", Email = "bill@email.com" },
            //    new Employee { EmployeeId = 2, HireDate = new DateTime(2012, 2, 16),  FirstName = "Rob", LastName = "aaaaaa", Email = "rob@email.com" },
            //    new Employee { EmployeeId = 3, HireDate = new DateTime(2012, 3, 14),  FirstName = "Jane", LastName = "bbbbbb", Email = "jane@email.com" }  
            //};
            var employees = new List<ConfigDto>
            {
                new ConfigDto { Id=1, Name = "aaa",  Value = "aaa"   },
                new ConfigDto { Id=2, Name = "bbb",  Value = "bbbb" },
                new ConfigDto { Id=3, Name = "ccc",  Value = "ccccc"  }  
            }; 
            Session["employees"] = employees;
        }


        protected void Application_Start()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<KendoDataContext>());
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}