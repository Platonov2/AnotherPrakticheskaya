using Storage.Infrastructure.Options;
using Storage.Contexts;
using Microsoft.EntityFrameworkCore;
using Storage.Infrastructure.Di;
using Business.Infrastructure.Di;
using Api.Common;
using Api.Automapper;
using FluentValidation;
using Api.Controllers.Boxes.Validators;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());

            });

        builder.Services.AddValidatorsFromAssemblyContaining<CreateBoxValidator>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var storageOptions = builder
            .Configuration
                .GetRequiredSection(StorageOptions.SectionName)
                .Get<StorageOptions>();

        builder.Services.AddStorage(storageOptions);
        builder.Services.AddBusiness();

        builder.Services.AddAutoMapper(typeof(ResponceMappingProfile));

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapControllers();

        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<StorageContext>();
            context.Database.Migrate();
            context.SaveChanges();
        }

        app.Run();
    }
}
