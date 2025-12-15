using LetPot.Platform.u202215721.Allocation.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Allocation.Domain.Model.Queries;
using LetPot.Platform.u202215721.Allocation.Domain.Repositories;
using LetPot.Platform.u202215721.Allocation.Domain.Services;

namespace LetPot.Platform.u202215721.Allocation.Application.Internal.QueryServices;

/// <summary>
/// Service implementation for pot queries.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public class PotQueryService(IPotRepository potRepository) : IPotQueryService
{
    /// <inheritdoc />
    public async Task<IEnumerable<Pot>> Handle(GetAllPotsQuery query)
    {
        return await potRepository.ListAsync();
    }

    /// <inheritdoc />
    public async Task<Pot?> Handle(GetPotByMacAddressQuery query)
    {
        return await potRepository.FindByMacAddressAsync(query.MacAddress);
    }
}
