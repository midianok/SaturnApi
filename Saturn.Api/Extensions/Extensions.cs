using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Saturn.Infrastructure.Database;

namespace Saturn.Api.Extensions;

public static class Extensions
{
    public static void ApplyMigrations(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider
            .GetRequiredService<IDbContextFactory<SaturnContext>>()
            .CreateDbContext();
       
        dbContext.Database.Migrate();
    }
    
    public static IServiceCollection AddSaturnContext(this IServiceCollection serviceCollection, ConfigurationManager configuration)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        var connectionString = configuration.GetConnectionString("Saturn");
        
        return serviceCollection.AddDbContextFactory<SaturnContext>(options =>
        {
            options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
            options.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }, ServiceLifetime.Transient);
    }
}