using System.Text.RegularExpressions;

namespace LetPot.Platform.u202215721.Allocation.Domain.Model.ValueObjects;

/// <summary>
/// Value object representing a MAC Address in the Allocation context.
/// </summary>
/// <param name="Address">The MAC address string.</param>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public partial record MacAddress(string Address)
{
    /// <summary>
    /// Default constructor for empty MAC address.
    /// </summary>
    public MacAddress() : this(string.Empty)
    {
    }

    /// <summary>
    /// Validates the MAC address format.
    /// </summary>
    /// <param name="address">The MAC address to validate.</param>
    /// <returns>True if valid, false otherwise.</returns>
    public static bool IsValid(string address)
    {
        if (string.IsNullOrWhiteSpace(address)) return false;
        return MacAddressRegex().IsMatch(address);
    }

    /// <summary>
    /// Gets the MAC address regex pattern.
    /// </summary>
    [GeneratedRegex(@"^([0-9A-Fa-f]{2}-){5}[0-9A-Fa-f]{2}$")]
    private static partial Regex MacAddressRegex();
}
