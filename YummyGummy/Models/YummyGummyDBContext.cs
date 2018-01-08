using System;
using Microsoft.EntityFrameworkCore;

namespace YummyGummy.Models
{
    public class YummyGummyDBContext : DbContext
    {
        public YummyGummyDBContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Port=8889;database=YummyGummy;uid=root;pwd=root;");
        }

        public YummyGummyDBContext(DbContextOptions<YummyGummyDBContext> options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
