using Microsoft.EntityFrameworkCore;
using Storage.Entities;
using Storage.Infrastructure.Generators;

namespace Storage.Contexts;

public class StorageContext : DbContext
{
    public DbSet<Box> Boxes => Set<Box>();
    public DbSet<Pallet> Pallets => Set<Pallet>();

    //public StorageContext() {  }

    public StorageContext(DbContextOptions<StorageContext> options) : base(options) { }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite("Data Source=dataBase.db");
        //optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=usersdb;Username=postgres;Password=postgres");
    }*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(StorageContext).Assembly);

        /*var (pallets, boxes) = DataGenerator.Generate();

        modelBuilder.Entity<Pallet>().HasData(pallets);
        modelBuilder.Entity<Box>().HasData(boxes);*/
    }
}
