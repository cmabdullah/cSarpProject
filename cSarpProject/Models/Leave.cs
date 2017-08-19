
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Models{
    
public class Leave
	{
		public Int32 Id { get; set; }
		public string CasualLeave { get; set; }
        public string StudyLeave { get; set; }
        public string Medical { get; set; }

	}
	public class EClassLeave
	{
        public List<Leave> LeaveF { get; set; }

	}
	public class EClassLeaveT
	{
		public List<Leave> LeaveFT { get; set; }

	}

}
