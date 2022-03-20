using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migration.MSSQL
{
	internal class NRTDbContextFactory : IDesignTimeDbContextFactory<NRTDbContext>
	{
		public NRTDbContext CreateDbContext(string[] args)
		{
			return new NRTDbContext(new DbContextOptionsBuilder().UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=NRTTest; Integrated Security=True").Options);
		}
	}
}
