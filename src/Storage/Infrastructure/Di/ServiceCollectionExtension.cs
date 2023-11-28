using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Storage.Contexts;
using Storage.Infrastructure.Options;
using Storage.Repositories.Boxes;
using Storage.Repositories.Pallets;

namespace Storage.Infrastructure.Di;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddStorage(this IServiceCollection services, StorageOptions storageOptions)
    {
        services.AddDbContext<StorageContext>(options =>
        {
            switch (storageOptions.Provider)
            {
                case "Sqlite":
                    options.UseSqlite(storageOptions.RequiredSqliteConnectionString);
                    //, opt => opt.MigrationsAssembly("SqliteMigrations"));
                    break;

                case "PgSql":
                    options.UseNpgsql(storageOptions.RequiredPgSqlConnectionString);
                    //, opt => opt.MigrationsAssembly("PgSqlMigrations"));
                    break;
            }
        });
            
        services.AddTransient<IPalletRepository, PalletRepository>();
        services.AddTransient<IBoxRepository, BoxRepository>();

        return services;
    }
}
