namespace LetPot.Platform.u202215721.Allocation.Interfaces.ACL;

/// <summary>
/// Public interface for the Allocation context facade.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public interface IAllocationContextFacade
{
    Task<bool> ExistsPotByMacAddress(string macAddress);
    Task<int> FetchPotIdByMacAddress(string macAddress);
}
