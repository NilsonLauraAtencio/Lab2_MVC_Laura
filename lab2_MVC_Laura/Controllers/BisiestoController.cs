﻿using lab2_MVC_Laura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2_MVC_Laura.Controllers
{
    public class BisiestoController : Controller
    {
        // GET: Bisiesto

  
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Visualizar(ClaseBisiesto objBisiesto)
        {
            return View(objBisiesto);
        }

    }
}