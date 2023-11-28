using Business.Infrastructure.Automapper;
using Business.Services.Box;
using Business.Services.Pallet;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Infrastructure.Di;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddBusiness(this IServiceCollection services)
    {
        services.AddTransient<IPalletService, PalletService>();
        services.AddTransient<IBoxService, BoxService>();

        services.AddAutoMapper(typeof(BoxMappingProfile));

        return services;
    }
}
