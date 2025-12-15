using LetPot.Platform.u202215721.Allocation.Domain.Model.Aggregates;
using LetPot.Platform.u202215721.Allocation.Interfaces.REST.Resources;

namespace LetPot.Platform.u202215721.Allocation.Interfaces.REST.Transform;

/// <summary>
/// Assembler to transform Pot entity to PotResource.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public static class PotResourceFromEntityAssembler
{
    /// <summary>
    /// Transforms a Pot entity to a PotResource.
    /// </summary>
    /// <param name="entity">The Pot entity.</param>
    /// <returns>The PotResource.</returns>
    public static PotResource ToResourceFromEntity(Pot entity)
    {
        return new PotResource(
            entity.Id,
            entity.MacAddress.Address,
            entity.CustomerId,
            entity.PreferredHumidityLevel);
    }
}
