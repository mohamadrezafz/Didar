using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Didar.Application.Interfaces;
using Didar.Infrastructure.Persistance;

namespace Didar.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services
        , IConfiguration configuration
    )
    {

        services.AddScoped<IApplicationDatabaseContext>(provider => provider.GetRequiredService<ApplicationDatabaseContext>());

        services.AddScoped<ApplicationDbContextInitialiser>();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDatabaseContext>(options =>
            options.UseSqlServer(
                connectionString,
                    builder => builder.MigrationsAssembly(typeof(ApplicationDatabaseContext).Assembly.FullName)
                )
        );


        return services;
    }
}
