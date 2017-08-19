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

		public IActionResult Salary()
		{
			var aaa = _context.Salary.ToList();
			EClassSalary cm = new EClassSalary
			{
				SalaryF = aaa
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
       
        public IActionResult AddEmployee([Bind("Id,FirstName,LastName, PermanentAddress, PresentAddress, ContactAddress, ContactMail, ContactNo, Phone")]Employee obj1)
		{
			using (var db1 = _context)
			{

                var std1 = new Employee
				{
					Id = obj1.Id,
					FirstName = obj1.FirstName,
                    LastName = obj1.LastName,
					PermanentAddress = obj1.PermanentAddress,
                    PresentAddress = obj1.PresentAddress,
                    ContactAddress = obj1.ContactAddress,
                    ContactMail = obj1.ContactMail,
                    ContactNo = obj1.ContactNo,
                    Phone = obj1.Phone,
				};
                db1.Employee.Add(std1);
				db1.SaveChanges();
			}
			return RedirectToAction("Join");
		}






		public IActionResult Leave()
		{
			var aaa = _context.Leave.ToList();
			EClassLeave cm = new EClassLeave
			{
				LeaveF = aaa
			};
			return View(cm);
		}



		public IActionResult SaveNotice([Bind("Id,NoticeType, NoticeName,NoticeDate")]Notice obj)
		{
			using (var db1 = _context)
			{
				var std = new Notice
				{
					Id = obj.Id,
					NoticeType = obj.NoticeType,
					NoticeName = obj.NoticeName,
                    NoticeDate = obj.NoticeDate
				};
				db1.Notice.Add(std);
				db1.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		public IActionResult Notice()
		{
			return View();
		}
    }
}
