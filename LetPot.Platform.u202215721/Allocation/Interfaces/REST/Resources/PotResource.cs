namespace LetPot.Platform.u202215721.Allocation.Interfaces.REST.Resources;

/// <summary>
/// Resource representing a pot.
/// </summary>
/// <param name="Id">The pot identifier.</param>
/// <param name="MacAddress">The MAC address.</param>
/// <param name="CustomerId">The customer identifier.</param>
/// <param name="PreferredHumidityLevel">The preferred humidity level.</param>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public record PotResource(
    int Id,
    string MacAddress,
    int CustomerId,
    decimal PreferredHumidityLevel);
