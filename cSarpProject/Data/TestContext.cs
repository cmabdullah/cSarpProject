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
			: base(options)
		{
		}

		public DbSet<cSarpProject.Models.Students> Students { get; set; }
      


	}

}