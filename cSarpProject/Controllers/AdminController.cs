﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult IDCreation()
		{
			return View();
		}


		public IActionResult UpdateAdBio()
		{
			return View();
		}
		public IActionResult Log()
		{
			return View();
		}
    }
}
