﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shawna_Staff.Controllers
{
    public class ReferencesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Online()
        {
            return View();
        }

        public IActionResult Printed()
        {
            return View();
        }
    }
}
