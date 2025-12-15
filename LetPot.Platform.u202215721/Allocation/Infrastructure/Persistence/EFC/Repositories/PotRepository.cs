using LetPot.Platform.u202215721.Allocation.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Allocation.Domain.Repositories;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LetPot.Platform.u202215721.Allocation.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// Repository implementation for pots.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public class PotRepository(AppDbContext context) : BaseRepository<Pot>(context), IPotRepository
{
    public async Task<Pot?> FindByMacAddressAsync(string macAddress)
    {
        return await Context.Set<Pot>()
            .FirstOrDefaultAsync(p => p.MacAddress.Address == macAddress);
    }
}
