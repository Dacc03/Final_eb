using LetPot.Platform.u202215721.Allocation.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Allocation.Domain.Model.Queries;

namespace LetPot.Platform.u202215721.Allocation.Domain.Services;

/// <summary>
/// Service interface for pot queries.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public interface IPotQueryService
{
    /// <summary>
    /// Handles the get all pots query.
    /// </summary>
    /// <param name="query">The query.</param>
    /// <returns>The list of pots.</returns>
    Task<IEnumerable<Pot>> Handle(GetAllPotsQuery query);

    /// <summary>
    /// Handles the get pot by MAC address query.
    /// </summary>
    /// <param name="query">The query.</param>
    /// <returns>The pot or null if not found.</returns>
    Task<Pot?> Handle(GetPotByMacAddressQuery query);
}
