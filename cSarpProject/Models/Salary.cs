using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Models{
    
public class Salary
	{
		public Int32 sId { get; set; }
		public string Basic { get; set; }
        public string Medical { get; set; }
        public string HouseRent { get; set; }
        public string Education { get; set; }
        public string Bonus { get; set; }
	}
	public class PhotoGallary113
	{
		public List<Salary> StudentAll113 { get; set; }

	}

}
