using Microsoft.EntityFrameworkCore;
using to_do_list_api.Model;

namespace to_do_list_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<To_do_list> to_Do_Lists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<To_do_list>().HasIndex(q => q.Name).IsUnique();
            base.OnModelCreating(modelBuilder);
        }

    }
}
