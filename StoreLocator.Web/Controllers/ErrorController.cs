﻿using StoreLocator.Models;
using StoreLocator.Provider;
using StoreLocator.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace StoreLocator.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Error500()
        {
            return View();
        }
    }
}