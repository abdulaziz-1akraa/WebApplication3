using Microsoft.EntityFrameworkCore;
using AyuEmlak.Models;

namespace AyuEmlak.Data
{
    public class EmlakDbContext : DbContext
    {
        public EmlakDbContext(DbContextOptions<EmlakDbContext> options) : base(options)
        {
        }

        public DbSet<Emlak> Emlaklar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Başlangıç Kategorileri
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { Id = 1, Ad = "Konut" },
                new Kategori { Id = 2, Ad = "İşyeri" },
                new Kategori { Id = 3, Ad = "Arsa" }
            );
        }
    }
}
