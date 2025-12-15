namespace LetPot.Platform.u202215721.Telemetry.Domain.Model.Queries;

/// <summary>
/// Query to retrieve a data record by identifier.
/// </summary>
/// <param name="DataRecordId">The data record identifier.</param>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public record GetDataRecordByIdQuery(int DataRecordId);
