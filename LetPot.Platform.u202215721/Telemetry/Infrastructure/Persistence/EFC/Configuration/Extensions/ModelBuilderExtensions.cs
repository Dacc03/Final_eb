using LetPot.Platform.u202215721.Telemetry.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace LetPot.Platform.u202215721.Telemetry.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Extension methods for configuring the Telemetry context model.
/// </summary>
/// <remarks>
/// Author: Deybbi Caviedes
/// </remarks>
public static class ModelBuilderExtensions
{
    public static void ApplyTelemetryConfiguration(this ModelBuilder builder)
    {
        builder.Entity<DataRecord>(entity =>
        {
            entity.ToTable("DataRecord");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            
            entity.OwnsOne(e => e.PotMacAddress, mac =>
            {
                mac.Property(m => m.Address).HasColumnName("pot_mac_address").IsRequired();
            });
            
            entity.Property(e => e.OperationMode).IsRequired();
            entity.Property(e => e.TargetHumidityLevel).HasPrecision(5, 2).IsRequired();
            entity.Property(e => e.CurrentHumidityLevel).HasPrecision(5, 2).IsRequired();
            entity.Property(e => e.OperationPhase).IsRequired();
            entity.Property(e => e.EmittedAt).IsRequired();
        });
    }
}
