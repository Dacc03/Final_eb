using LetPot.Platform.u202215721.Allocation.Domain.Model.Queries;
using LetPot.Platform.u202215721.Allocation.Domain.Services;
using LetPot.Platform.u202215721.Allocation.Interfaces.ACL;

namespace LetPot.Platform.u202215721.Allocation.Application.ACL.Services;

/// <summary>
/// Facade for the Allocation context.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public class AllocationContextFacade(IPotQueryService potQueryService) : IAllocationContextFacade
{
    public async Task<bool> ExistsPotByMacAddress(string macAddress)
    {
        var pot = await potQueryService.Handle(new GetPotByMacAddressQuery(macAddress));
        return pot != null;
    }

    public async Task<int> FetchPotIdByMacAddress(string macAddress)
    {
        var pot = await potQueryService.Handle(new GetPotByMacAddressQuery(macAddress));
        return pot?.Id ?? 0;
    }
}
