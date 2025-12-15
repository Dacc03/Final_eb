using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using LetPot.Platform.u202215721.Allocation.Infrastructure.Persistence.EFC.Configuration.Extensions;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using LetPot.Platform.u202215721.Telemetry.Infrastructure.Persistence.EFC.Configuration.Extensions;
using Microsoft.EntityFrameworkCore;

namespace LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration;

/// <summary>
/// The application's database context using Entity Framework Core.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    /// <summary>
    /// Configures the database context options.
    /// </summary>
    /// <param name="builder">The options' builder.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        // Automatically set CreatedAt and UpdatedAt for entities
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }

    /// <summary>
    /// Configures the model for the database context.
    /// </summary>
    /// <param name="builder">The model builder.</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Apply Telemetry context configurations
        builder.ApplyTelemetryConfiguration();

        // Apply Allocation context configurations
        builder.ApplyAllocationConfiguration();

        // Apply naming convention to use snake_case for database objects
        builder.UseSnakeCaseNamingConvention();
    }
}
