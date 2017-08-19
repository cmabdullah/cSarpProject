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
    public class AdminController : Controller
    {
		// GET: /<controller>/


		private readonly TestContext _context;
		public AdminController(TestContext context)
		{
			_context = context;

		}
        public IActionResult Index()
        {
			var aaa = _context.Employee1.ToList();
			EClass cm = new EClass
			{
				StudentF = aaa
			};
			return View(cm);
        }
		public IActionResult IDCreation()
		{
			return View();
		}





		public IActionResult UpdateAdBio()
		{
			var aaa = _context.Notice.ToList();
			EClassNoticeA cm = new EClassNoticeA
			{
				NoticeFA = aaa
			};
			return View(cm);
		}
		public IActionResult Log()
		{
			return View();
		}
    }
}
