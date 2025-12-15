using LetPot.Platform.u202215721.Telemetry.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Telemetry.Domain.Model.Queries;
using LetPot.Platform.u202215721.Telemetry.Domain.Repositories;
using LetPot.Platform.u202215721.Telemetry.Domain.Services;

namespace LetPot.Platform.u202215721.Telemetry.Application.Internal.QueryServices;

/// <summary>
/// Service implementation for data record queries.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public class DataRecordQueryService(IDataRecordRepository dataRecordRepository) : IDataRecordQueryService
{
    /// <inheritdoc />
    public async Task<DataRecord?> Handle(GetDataRecordByIdQuery query)
    {
        return await dataRecordRepository.FindByIdAsync(query.DataRecordId);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<DataRecord>> Handle(GetAllDataRecordsQuery query)
    {
        return await dataRecordRepository.ListAsync();
    }
}
