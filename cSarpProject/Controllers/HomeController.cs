using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cSarpProject.Controllers
{
    public class HomeController : Controller
    {

		/**

        private readonly TestContext _context;
        public HomeController (TestContext)
        

        */
        //connect with database
		private readonly TestContext _context;
		public HomeController(TestContext context)
		{
			_context = context;
		}


		public IActionResult Index()
        {
            return View();
        }

        public IActionResult PhotoGallary()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
		/***
        public IActionResult About()
        {
            return View();
        }
        ****/



		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";
			var test = _context.InstitutionDetails.FirstOrDefault();
			InstitutionDetails model = new InstitutionDetails
			{
				Id = test.Id,
				Name = test.Name

			};

			return View(model);

			//return View();
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
