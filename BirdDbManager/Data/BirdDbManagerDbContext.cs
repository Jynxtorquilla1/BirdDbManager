using Microsoft.EntityFrameworkCore;
using BirdDbManager.Entities;

namespace BirdDbManager.Data
{
    internal class BirdDbManagerDbContext : DbContext
    {
        public DbSet<Species> Species => Set<Species>();

        public DbSet<Observer> Observers => Set<Observer>();

        public DbSet<StudyArea> StudyAreas => Set<StudyArea>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }

    }
}
