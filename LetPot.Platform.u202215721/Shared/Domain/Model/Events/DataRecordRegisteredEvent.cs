using Cortex.Mediator.Notifications;

namespace LetPot.Platform.u202215721.Shared.Domain.Model.Events;

/// <summary>
/// Integration event emitted when a data record is registered.
/// </summary>
/// <param name="PotMacAddress">The MAC address of the pot.</param>
/// <param name="TargetHumidityLevel">The target humidity level.</param>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public record DataRecordRegisteredEvent(string PotMacAddress, decimal TargetHumidityLevel) : IEvent, INotification;
