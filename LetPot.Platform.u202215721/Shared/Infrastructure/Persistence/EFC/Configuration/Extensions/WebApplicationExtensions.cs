using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration;
using Microsoft.EntityFrameworkCore;

namespace LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Extension methods for configuring web application.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public static class WebApplicationExtensions
{
    /// <summary>
    /// Ensures the database is created.
    /// </summary>
    /// <param name="app">The web application.</param>
    /// <returns>The web application.</returns>
    public static WebApplication UseDatabaseCreationAssurance(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        context.Database.EnsureCreated();
        return app;
    }
}
