﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reference.Framework.Web.Controllers
{
    public class WorkoutController : Controller
    {
        // GET: Workout
        public ActionResult Index()
        {
            return View();
        }
    }
}