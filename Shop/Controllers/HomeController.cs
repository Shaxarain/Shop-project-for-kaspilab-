﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBs.Production;
using Funcs;
using System.Data.Entity;
using System.Data;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        Prod prod = new Prod();
        public ActionResult Index()
        {
            IEnumerable<Product> prods = prod.Product.Include("ProductProductPhoto").Include("ProductProductPhoto.ProductPhoto");
            ViewBag.Productions = prods;

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
    }
}