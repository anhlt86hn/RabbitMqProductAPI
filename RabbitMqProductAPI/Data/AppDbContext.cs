using Microsoft.EntityFrameworkCore;
using RabbitMqProductAPI.Models;

namespace RabbitMqProductAPI.Data
{
	public class AppDbContext : DbContext
	{
		protected readonly IConfiguration _configuration;
		public AppDbContext(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
		}

		public DbSet<Product> Products { get; set; }
	}
}
