using LetPot.Platform.u202215721.Shared.Domain.Repositories;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Extension methods for configuring database services.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public static class WebApplicationBuilderExtensions
{
    /// <summary>
    /// Adds database services to the application.
    /// </summary>
    /// <param name="builder">The web application builder.</param>
    /// <returns>The web application builder.</returns>
    public static WebApplicationBuilder AddDatabaseServices(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseMySQL(connectionString!);
        });

        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

        return builder;
    }
}
