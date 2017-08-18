using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cSarpProject.Data;
using cSarpProject.Models;
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
			/**
            ViewData["Message"] = "Your application description page.";
			var test = _context.Students.ToList();
			StudentList studentModel = new StudentList{
				StudentAll = test
			};
            return View();
            **/


			var test = _context.Students.ToList();
			PhotoGallary cm = new PhotoGallary
			{
				StudentAll = test
			};
			return View(cm);
        }

		public IActionResult About()
		{
			var aaa = _context.Teacher.ToList();
			PhotoGallary1 cm = new PhotoGallary1
			{
				StudentAll1 = aaa
			};
			return View(cm);
		}




		public IActionResult StudentsList()
		{
			var test = _context.Students.ToList();
			StudentList cm = new StudentList{
				StudentAll = test
			};
			return View(cm);
		}



		public IActionResult AdcPanel()
		{
			return View();
		}
		public IActionResult AddStudent(){
			return View();
		}



		public IActionResult SaveStudent([Bind("Id,Name, Program")]Students students){
			using (var db = _context){

				var std = new Students{
					Id = students.Id,
					Name = students.Name,
					Program = students.Program
				};
				db.Students.Add(std);
				db.SaveChanges();
			}
			return RedirectToAction("StudentsList");
		}





        public IActionResult Error()
        {
            return View();
        }
    }
}
