using LetPot.Platform.u202215721.Allocation.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace LetPot.Platform.u202215721.Allocation.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Extension methods for configuring the Allocation context model.
/// </summary>
/// <remarks>
/// Author: Antonio Rodrigo Duran Diaz
/// </remarks>
public static class ModelBuilderExtensions
{
    public static void ApplyAllocationConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Pot>(entity =>
        {
            entity.ToTable("Pot");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.OwnsOne(e => e.MacAddress, mac =>
            {
                mac.WithOwner().HasForeignKey("Id");
                mac.HasKey("Id");
                mac.Property<int>("Id").HasColumnName("id");
                mac.Property(m => m.Address).HasColumnName("mac_address").IsRequired();
            });
            
            entity.Property(e => e.CustomerId).IsRequired();
            entity.Property(e => e.PreferredHumidityLevel).HasPrecision(5, 2).IsRequired();
        });

        // Seed initial data
        SeedPots(builder);
    }

    private static void SeedPots(ModelBuilder builder)
    {
        builder.Entity<Pot>().HasData(
            new
            {
                Id = 1,
                CustomerId = 2,
                PreferredHumidityLevel = 40.0m
            },
            new
            {
                Id = 2,
                CustomerId = 4,
                PreferredHumidityLevel = 70.0m
            },
            new
            {
                Id = 3,
                CustomerId = 3,
                PreferredHumidityLevel = 45.5m
            },
            new
            {
                Id = 4,
                CustomerId = 1,
                PreferredHumidityLevel = 57.5m
            }
        );

        // Seed MacAddress separately as owned entity
        builder.Entity<Pot>().OwnsOne(p => p.MacAddress).HasData(
            new { Id = 1, Address = "67-E0-B5-2B-DB-67" },
            new { Id = 2, Address = "69-3D-91-E2-AA-DC" },
            new { Id = 3, Address = "37-AA-35-CE-E6-C2" },
            new { Id = 4, Address = "FA-8C-71-C2-C4-79" }
        );
    }
}
