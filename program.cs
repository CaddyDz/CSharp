using System;
using System.IO;
using System.Linq;
using Databases.Models;

namespace Databases
{
	class Program
	{
		static void Main(string[] args)
		{
			string dbName = "TestDatabase.db";
			if (File.Exists(dbName))
			{
				File.Delete(dbName);
			}
			using (var dbContext = new MyDbContext())
			{
				// Ensure database is created
				dbContext.Database.EnsureCreated();
				if (!dbContext.Products.Any())
				{
					// Create a products array and add to it via a for loop
					dbContext.Products.AddRange(new Product[] {
						new Product
						{
							id = 1,
							title = "Product 1",
							sub_title = "Product 2 subtitle"
						},
												new Product
						{
							id = 2,
							title = "Product 2",
							sub_title = "Product 2 subtitle"
						},
												new Product
						{
							id = 3,
							title = "Product 3",
							sub_title = "Product 2 subtitle"
						}
				});
					dbContext.SaveChanges();
				}
				foreach (var product in dbContext.Products)
				{
					System.Console.WriteLine($"Product ID = {product.id}\tTitle={product.title}\t{product.sub_title}\tDate added={product.created_at}");
				}
			}
			Console.ReadLine();
		}
	}
}
