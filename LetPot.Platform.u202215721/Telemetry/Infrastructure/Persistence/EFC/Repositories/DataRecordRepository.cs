using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Configuration;
using LetPot.Platform.u202215721.Shared.Infrastructure.Persistence.EFC.Repositories;
using LetPot.Platform.u202215721.Telemetry.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Telemetry.Domain.Repositories;

namespace LetPot.Platform.u202215721.Telemetry.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// Repository implementation for data records.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public class DataRecordRepository(AppDbContext context) : BaseRepository<DataRecord>(context), IDataRecordRepository
{
}
