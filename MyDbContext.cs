using Databases.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Databases
{
	class MyDbContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// UseSqlite extended function is to configure the connection string.
			optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
			{
				// Migration assembly is configured.
				options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
			});
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Map table names.
			// table name is mapped to test.products.
			modelBuilder.Entity<Product>().ToTable("products", "test");
			modelBuilder.Entity<Product>(entity =>
			{
				entity.HasKey(e => e.id);
				// Title column is configured as unique index.
				entity.HasIndex(e => e.title).IsUnique();
				// Column created_at's default value is configured using SQL timestamp
				entity.Property(e => e.created_at).HasDefaultValueSql("CURRENT_TIMESTAMP");
			});
			base.OnModelCreating(modelBuilder);
		}
	}
}
