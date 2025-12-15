namespace LetPot.Platform.u202215721.Allocation.Interfaces.ACL;

/// <summary>
/// Public interface for the Allocation context facade.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public interface IAllocationContextFacade
{
    Task<bool> ExistsPotByMacAddress(string macAddress);
    Task<int> FetchPotIdByMacAddress(string macAddress);
}
