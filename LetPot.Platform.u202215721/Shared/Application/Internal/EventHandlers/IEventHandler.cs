using Cortex.Mediator.Notifications;
using LetPot.Platform.u202215721.Shared.Domain.Model.Events;

namespace LetPot.Platform.u202215721.Shared.Application.Internal.EventHandlers;

/// <summary>
/// Base interface for event handlers.
/// </summary>
/// <typeparam name="TEvent">The type of event to handle.</typeparam>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent, INotification
{
}