using LetPot.Platform.u202215721.Allocation.Domain.Repositories;
using LetPot.Platform.u202215721.Shared.Application.Internal.EventHandlers;
using LetPot.Platform.u202215721.Shared.Domain.Model.Events;
using LetPot.Platform.u202215721.Shared.Domain.Repositories;

namespace LetPot.Platform.u202215721.Allocation.Application.Internal.EventHandlers;

/// <summary>
/// Event handler for DataRecordRegisteredEvent.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public class DataRecordRegisteredEventHandler(
    IPotRepository potRepository,
    IUnitOfWork unitOfWork) : IEventHandler<DataRecordRegisteredEvent>
{
    public async Task Handle(DataRecordRegisteredEvent notification, CancellationToken cancellationToken = default)
    {
        var pot = await potRepository.FindByMacAddressAsync(notification.PotMacAddress);
        
        if (pot == null) return;

        if (pot.PreferredHumidityLevel != notification.TargetHumidityLevel)
        {
            pot.UpdatePreferredHumidityLevel(notification.TargetHumidityLevel);
            potRepository.Update(pot);
            await unitOfWork.CompleteAsync();
        }
    }
}