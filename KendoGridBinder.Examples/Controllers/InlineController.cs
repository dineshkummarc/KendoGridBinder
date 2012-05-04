using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoGridBinder.Examples.Models;

namespace KendoGridBinder.Examples.Controllers
{
    public class InlineController : Controller
    {
        //
        // GET: /Inline/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewPage1()
        {
            return View();
        }




        [HttpGet]
        public ActionResult AjaxRead(KendoGridBinder.KendoGridRequest request)
        {
            var list = Session["employees"];
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public void AjaxUpdate(FormCollection fc)
        {
            // update
        }
        [HttpPost]
        public void AjaxDestroy(FormCollection fc)
        {
            // Delete
        }
        [HttpPost]
        public void AjaxCreate(FormCollection fc)
        {
            // Create
        }
 





    }
}
