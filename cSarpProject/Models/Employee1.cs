using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Models{
    
public class Employee1
	{
		public Int32 Id { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }

	}
	public class EClass
	{
		public List<Employee1> StudentF { get; set; }

	}

}
