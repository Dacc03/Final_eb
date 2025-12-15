using System.Text.RegularExpressions;

namespace LetPot.Platform.u202215721.Telemetry.Domain.Model.ValueObjects;

/// <summary>
/// Value object representing a MAC Address.
/// </summary>
/// <param name="Address">The MAC address string.</param>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public partial record MacAddress
{
    /// <summary>
    /// Initializes a new instance of <see cref="MacAddress"/> for EF Core materialization.
    /// </summary>
    public MacAddress()
    {
        Address = string.Empty;
    }

    /// <summary>
    /// Initializes a new instance of <see cref="MacAddress"/> with validation.
    /// </summary>
    /// <param name="address">The MAC address string.</param>
    /// <exception cref="ArgumentException">Thrown when the address format is invalid.</exception>
    public MacAddress(string address)
    {
        if (!IsValid(address))
            throw new ArgumentException("Invalid MAC Address format", nameof(address));

        Address = address;
    }

    /// <summary>
    /// Gets the normalized MAC address string.
    /// </summary>
    public string Address { get; private set; }

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
