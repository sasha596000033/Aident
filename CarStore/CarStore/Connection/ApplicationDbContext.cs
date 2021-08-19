using CarStore.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Connection
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<CarDescriptionEntity> CarDescriptions { get; set; }
        public DbSet<CarFeaturesEntity> CarFeatures { get; set; }
        public DbSet<DescriptionFeaturesEntity> DescriptionFeatures { get; set; }
    }
}