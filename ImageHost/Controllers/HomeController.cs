﻿using ImageHost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageHost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var works = new List<Work>();
            using (var db = new ApplicationDbContext())
            {
                works = db.Works.Include("Author").ToList();
            }
            return View(works);
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