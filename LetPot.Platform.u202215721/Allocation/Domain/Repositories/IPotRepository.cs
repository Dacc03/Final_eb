using LetPot.Platform.u202215721.Allocation.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Shared.Domain.Repositories;

namespace LetPot.Platform.u202215721.Allocation.Domain.Repositories;

/// <summary>
/// Repository interface for pots.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public interface IPotRepository : IBaseRepository<Pot>
{
    /// <summary>
    /// Finds a pot by its MAC address.
    /// </summary>
    /// <param name="macAddress">The MAC address.</param>
    /// <returns>The pot or null if not found.</returns>
    Task<Pot?> FindByMacAddressAsync(string macAddress);
}
