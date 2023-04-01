using System;
using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Article> Articles { get; set; }
		public DbSet<Author> Authors { get; set; }
    }
}

