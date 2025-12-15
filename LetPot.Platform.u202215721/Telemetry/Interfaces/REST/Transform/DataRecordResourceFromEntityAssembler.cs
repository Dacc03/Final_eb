using LetPot.Platform.u202215721.Telemetry.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Telemetry.Interfaces.REST.Resources;

namespace LetPot.Platform.u202215721.Telemetry.Interfaces.REST.Transform;

/// <summary>
/// Assembler to transform DataRecord entity to DataRecordResource.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public static class DataRecordResourceFromEntityAssembler
{
    /// <summary>
    /// Transforms a DataRecord entity to a DataRecordResource.
    /// </summary>
    /// <param name="entity">The DataRecord entity.</param>
    /// <returns>The DataRecordResource.</returns>
    public static DataRecordResource ToResourceFromEntity(DataRecord entity)
    {
        return new DataRecordResource(
            entity.Id,
            entity.PotMacAddress.Address,
            entity.OperationMode.ToString(),
            entity.TargetHumidityLevel,
            entity.CurrentHumidityLevel,
            entity.OperationPhase.ToString(),
            entity.EmittedAt.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
