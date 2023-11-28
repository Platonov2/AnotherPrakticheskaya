using Microsoft.EntityFrameworkCore;
using Storage.Entities;
using Storage.Infrastructure.Generators;

namespace Storage.Contexts;

public class StorageContext : DbContext
{
    public DbSet<BoxRecord> Boxes => Set<BoxRecord>();
    public DbSet<PalletRecord> Pallets => Set<PalletRecord>();

    public StorageContext() {  }

    public StorageContext(DbContextOptions<StorageContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite("Data Source=dataBase.db");
        //optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=usersdb;Username=postgres;Password=postgres");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*modelBuilder.ApplyConfigurationsFromAssembly(typeof(StorageContext).Assembly);

        var (pallets, boxes) = DataGenerator.Generate();

        modelBuilder.Entity<PalletRecord>().HasData(pallets);
        modelBuilder.Entity<BoxRecord>().HasData(boxes);*/
    }
}
