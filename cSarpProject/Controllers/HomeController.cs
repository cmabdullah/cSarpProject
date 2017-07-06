using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cSarpProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PhotoGallary()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

		public IActionResult Login()
		{
			return View();
		}

		public IActionResult AdcPanel()
		{
			return View();
		}





        public IActionResult Error()
        {
            return View();
        }
    }
}
