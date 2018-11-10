using Microsoft.EntityFrameworkCore;

namespace My_Second_Website
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options)
			: base(options)
		{

		}

		public DbSet<Customer> Customers { get; set; }
	}
}