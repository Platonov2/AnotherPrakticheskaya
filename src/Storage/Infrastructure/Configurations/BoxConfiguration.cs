using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Entities;

namespace Storage.Infrastructure.Configurations;

internal sealed class BoxConfiguration : IEntityTypeConfiguration<Box>
{
    public void Configure(EntityTypeBuilder<Box> builder)
    {
        builder.HasOne<Pallet>()
            .WithMany(p => p.Boxes)
            .HasForeignKey(b => b.PalletId);
        builder.HasIndex(b => b.Id).IsUnique();

        builder.Property(b => b.Length).IsRequired();
        builder.Property(b => b.Height).IsRequired();
        builder.Property(b => b.Width).IsRequired();
        builder.Property(b => b.Weight).IsRequired();
        builder.Property(b => b.ManufacturingDate).IsRequired();
        builder.Property(b => b.ExpirationDate).IsRequired();

        builder.ToTable("Boxes");
    }
}
