﻿using System.Web.Mvc;

namespace StoreLocator.Web.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Links()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}
