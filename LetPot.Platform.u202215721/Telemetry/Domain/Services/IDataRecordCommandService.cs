using LetPot.Platform.u202215721.Telemetry.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Telemetry.Domain.Model.Commands;

namespace LetPot.Platform.u202215721.Telemetry.Domain.Services;

/// <summary>
/// Service interface for data record commands.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public interface IDataRecordCommandService
{
    /// <summary>
    /// Handles the create data record command.
    /// </summary>
    /// <param name="command">The create data record command.</param>
    /// <returns>The created data record or null if failed.</returns>
    Task<DataRecord?> Handle(CreateDataRecordCommand command);
}
