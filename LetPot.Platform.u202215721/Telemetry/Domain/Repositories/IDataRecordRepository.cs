using LetPot.Platform.u202215721.Shared.Domain.Repositories;
using LetPot.Platform.u202215721.Telemetry.Domain.Model.Aggregates;

namespace LetPot.Platform.u202215721.Telemetry.Domain.Repositories;

/// <summary>
/// Repository interface for data records.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public interface IDataRecordRepository : IBaseRepository<DataRecord>
{
}
