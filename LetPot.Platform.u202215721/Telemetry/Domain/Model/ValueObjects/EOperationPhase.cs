namespace LetPot.Platform.u202215721.Telemetry.Domain.Model.ValueObjects;

/// <summary>
/// Enumeration representing the operation phase of a pot.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public enum EOperationPhase
{
    /// <summary>
    /// The pot is waiting.
    /// </summary>
    WAITING = 0,

    /// <summary>
    /// The pot is watering.
    /// </summary>
    WATERING = 1
}
