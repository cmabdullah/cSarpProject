using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Models{
    
public class Students
	{
		public Int32 Id { get; set; }
		public string Name { get; set; }
        public string Program { get; set; }
	}
	public class StudentList
	{
		public List<Students> StudentAll { get; set; }

	}
}
