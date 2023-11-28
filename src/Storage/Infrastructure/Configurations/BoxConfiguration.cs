using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Storage.Entities;

namespace Storage.Infrastructure.Configurations;

internal sealed class BoxConfiguration : IEntityTypeConfiguration<BoxRecord>
{
    public void Configure(EntityTypeBuilder<BoxRecord> builder)
    {
        builder.HasOne<PalletRecord>()
            .WithMany(p => p.Boxes)
            .HasForeignKey(b => b.PalletRecordId);
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
