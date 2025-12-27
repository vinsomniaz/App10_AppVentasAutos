using Microsoft.EntityFrameworkCore;
using App10_AppVentasAutos.Models;

namespace App10_AppVentasAutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Auto> Autos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>()
                .Property(a => a.FechaRegistro)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Auto>()
                .Property(a => a.Precio)
                .HasPrecision(18, 2);
        }
    }
}
