using System;
using Microsoft.EntityFrameworkCore;
using blogs_api.Models;

namespace blogs_api.Repository
{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions<BlogContext> options): base(options)
		{ }

		public BlogContext() { }

		public DbSet<User> Users { get; set; }
		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<PostCategory> PostCategories { get; set; }

		protected override void OnModelCreating(ModelBuilder mb)
		{
			mb.Entity<PostCategory>().HasKey(x => new { x.CategoryId, x.PostId });
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var connectionString = "Server=127.0.0.1;Database=blogs_db;User=SA;Password=Password12!;TrustServerCertificate=true";

				optionsBuilder.UseSqlServer(connectionString);
			}
		}
	}
}

