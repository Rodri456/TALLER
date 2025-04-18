﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TALLER.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Mecanicos()
        {
            return View();
        }

        public ActionResult Clientes()
        {
            return View();
        }

        public ActionResult Recepcionista()
        {
            return View();
        }

        public ActionResult Trabajos()
        {
            return View();
        }
    }
}