using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
	public class NRTDbContext : DbContext
	{
		public DbSet<Client> Clients { get; private set; }

		public NRTDbContext(DbContextOptions options) : base(options)
		{
		}

		protected NRTDbContext()
		{
		}
	}
}
