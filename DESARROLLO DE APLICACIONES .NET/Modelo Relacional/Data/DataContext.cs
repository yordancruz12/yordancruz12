using Microsoft.EntityFrameworkCore;
using Modelo_Relacional.Data.Entities;

namespace Modelo_Relacional.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
