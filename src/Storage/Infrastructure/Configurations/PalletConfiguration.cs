using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Entities;

namespace Storage.Infrastructure.Configurations;

internal sealed class PalletConfiguration : IEntityTypeConfiguration<Pallet>
{
    public void Configure(EntityTypeBuilder<Pallet> builder)
    {
        builder.HasIndex(p => p.Id).IsUnique();

        builder.Property(b => b.Length).IsRequired();
        builder.Property(b => b.Weight).IsRequired();
        builder.Property(b => b.Width).IsRequired();
        builder.Property(b => b.Height).IsRequired();

        builder.Ignore(b => b.ExpirationDate);

        builder.ToTable("Pallets");
    }
}
