using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Models{
    
public class Employee
	{
		public Int32 Id { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string ContactAddress { get; set; }
        public string ContactMail { get; set; }
        public string ContactNo { get; set; }
        public string Phone { get; set; }
	}
	public class PhotoGallary12
	{
		public List<Employee> StudentAll12 { get; set; }

	}

}
