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
    public class TeacherController : Controller
    {
		// GET: /<controller>/


		private readonly TestContext _context;
		public TeacherController(TestContext context)
		{
			_context = context;

		}
        public IActionResult Index()
        {
			var aaa = _context.Employee.ToList();
			PhotoGallary123 cm = new PhotoGallary123
			{
				StudentAll123 = aaa
			};
			return View(cm);
        }
		public IActionResult Salary()
		{
			var aaa = _context.Salary.ToList();
			EClassSalaryT cm = new EClassSalaryT
			{
				SalaryFT = aaa
			};
			return View(cm);
		}
		public IActionResult Attendence()
		{
			return View();
		}

		public IActionResult Leave()
		{
			var aaa = _context.Leave.ToList();
			EClassLeaveT cm = new EClassLeaveT
			{
				LeaveFT = aaa
			};
			return View(cm);
		}
		public IActionResult Notice()
		{
            var aaa = _context.Notice.ToList();
			EClassNoticeT cm = new EClassNoticeT
			{
				NoticeFT = aaa
			};
			return View(cm);
		}
    }
}
