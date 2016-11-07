using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentQueries
{
	class Mrrr : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Group> Groups { get; set; }

		public Mrrr() : base("localsql")
		{

		}
	}
}
