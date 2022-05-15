using WebApplicationExam2.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationExam2.Infrastructure.DataBase
{
    public class ShopeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = .; Database = DBExam2; User Id = sa; Password = 123456;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
