﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administrator.Controllers
{
    public class MainController : Controller
    {

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Menubar()
        {
            return this.View();
        }

    }
}
