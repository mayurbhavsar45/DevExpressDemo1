using DevExpress.Web;
using DevExpress.Web.Internal;
using DXWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace DXWebApplication1.Controllers
{
    public class FilterBuilderController : Controller
    {
        //
        // GET: /FilterBuilder/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FilterBuilder()
        {
            return DemoView("FilterBuilder", NorthwindDataProvider.GetEmployeesList());
        }
        public ActionResult FilterBuilderPartial()
        {
            return PartialView("FilterBuilderPartial", NorthwindDataProvider.GetEmployeesList());
        }
        public ActionResult DemoView(string actionName, object model)
        {
            return DemoView(actionName, actionName, model);
        }
        public ActionResult DemoView(string actionName, string viewName, object model)
        {
            RegisterCurrentMvcDemo("FilterBuilder", actionName);
            return (model != null) ? View(viewName, model) : View(viewName);
        }
        public static void RegisterCurrentMvcDemo(string controllerName, string actionName)
        {
            RegisterCurrentDemo(controllerName, actionName);
        }
        static void RegisterCurrentDemo(string groupKey, string demoKey)
        {
            DevExpress.Web.Internal.DemoUtils.RegisterDemo("FilterBuilder", groupKey, demoKey);
        }
    }
}
