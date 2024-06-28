using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Npgsql;

namespace Bunker.Domain;

public static class ServiceRegistrar
{
    [Obsolete("Obsolete")]
    public static IServiceCollection RegisterDataAccessService(
        this IServiceCollection services,
        IConfiguration configuration,
        bool isDevelopment)
    {
        NpgsqlConnection.GlobalTypeMapper.EnableDynamicJson();
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("BunkerContext"));
            if (isDevelopment)
            {
                options.EnableSensitiveDataLogging();
            }
        });
        return services;
    }

    public static void MigrateDb(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
        var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
        context?.Database.Migrate();
    }
}
