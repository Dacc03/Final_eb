using LetPot.Platform.u202215721.Telemetry.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Telemetry.Domain.Model.Queries;

namespace LetPot.Platform.u202215721.Telemetry.Domain.Services;

/// <summary>
/// Service interface for data record queries.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public interface IDataRecordQueryService
{
    /// <summary>
    /// Handles the get data record by identifier query.
    /// </summary>
    /// <param name="query">The query.</param>
    /// <returns>The data record or null if not found.</returns>
    Task<DataRecord?> Handle(GetDataRecordByIdQuery query);

    /// <summary>
    /// Handles the get all data records query.
    /// </summary>
    /// <param name="query">The query.</param>
    /// <returns>The list of data records.</returns>
    Task<IEnumerable<DataRecord>> Handle(GetAllDataRecordsQuery query);
}
