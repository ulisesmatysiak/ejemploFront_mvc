﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ejemplosFront.App_Code;

namespace ejemplosFront.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int cuil = 0)
        {
            var personaViewModel = invocaejemplosAnses.obtenerPersona(cuil);

            return View(personaViewModel);
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
    }
}