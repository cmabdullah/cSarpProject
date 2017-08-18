using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cSarpProject.Data;
using cSarpProject.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Controllers
{
    public class AccounceController : Controller
    {
		// GET: /<controller>/


		private readonly TestContext _context;
		public AccounceController(TestContext context)
		{
			_context = context;

		}
        public IActionResult Index()
        {
			var aaa = _context.Employee.ToList();
			PhotoGallary12 cm = new PhotoGallary12{
				StudentAll12 = aaa
			};
			return View(cm);
        }


		
        public IActionResult Attendence()
		{
			return View();
		}

		public IActionResult Join()
		{
			return View();
		}
		public IActionResult Leave()
		{
			return View();
		}
		public IActionResult Notice()
		{
			return View();
		}
    }
}
