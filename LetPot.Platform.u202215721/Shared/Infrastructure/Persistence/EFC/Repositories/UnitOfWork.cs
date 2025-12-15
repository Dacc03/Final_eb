using LetPot.Platform.u202215721.Shared.Domain.Repositories;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// Implementation of the unit of work pattern.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task<int> CompleteAsync() => await context.SaveChangesAsync();
}
