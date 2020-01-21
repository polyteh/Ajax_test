using MVC_Timer_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MVC_Timer_Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            StringList strList = new StringList();
            strList.status.Add(DateTime.Now.ToString());
            ViewBag.status = strList;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [OutputCache(NoStore = true, Location = OutputCacheLocation.Client, Duration = 3)]
        public PartialViewResult _GetforStatus()
        {
            StringList strList = new StringList();
            strList.status.Add(DateTime.Now.ToString());
            return PartialView("_GetforStatus", strList);
        }
    }
}