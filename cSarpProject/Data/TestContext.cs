﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cSarpProject.Data
{
    public class TestContext : DbContext
	{

		public TestContext(DbContextOptions<TestContext> options)
			: base(options){
		}
		public DbSet<cSarpProject.Models.Teacher> Teacher { get; set; }
		public DbSet<cSarpProject.Models.Students> Students { get; set; }
        public DbSet<cSarpProject.Models.Employee> Employee { get; set; }
		public DbSet<cSarpProject.Models.Employee1> Employee1 { get; set; }
        public DbSet<cSarpProject.Models.Salary> Salary { get; set; }
        public DbSet<cSarpProject.Models.Leave> Leave { get; set; }
        public DbSet<cSarpProject.Models.Notice> Notice { get; set; }

  
       
      
	}




}
