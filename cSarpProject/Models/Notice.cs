using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Models{
    
public class Notice
	{
		public Int32 Id { get; set; }
		public string NoticeType { get; set; }
        public string NoticeName { get; set; }
        public string NoticeDate { get; set; }
	}
	public class ClassNotice
	{
		public List<Notice> NoticeF { get; set; }

	}

	public class EClassNoticeT
	{
		public List<Notice> NoticeFT { get; set; }

	}
	public class EClassNoticeA
	{
		public List<Notice> NoticeFA { get; set; }

	}

}
