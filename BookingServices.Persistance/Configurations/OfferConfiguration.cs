using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class OfferConfiguration : BaseEntityConfiguration<Offer>
    {
        public override void Configure(EntityTypeBuilder<Offer> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.PerformerId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.Cost).HasPrecision(9, 2);
            builder.Property(x => x.StartOfService)
                .IsRequired()
                .HasColumnType("datetime2")
                .HasPrecision(0);
            builder.Property(x => x.EndOfService)
                .IsRequired()
                .HasColumnType("datetime2")
                .HasPrecision(0);
            builder
                .HasOne(so => so.Product)
                .WithMany(sp => sp.Offers)
                .HasForeignKey(so => so.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(so => so.Performer)
                .WithMany(sp => sp.Offers)
                .HasForeignKey(so => so.PerformerId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasIndex(x => x.StartOfService);
            builder.HasIndex(x => x.EndOfService);
            builder.HasIndex(x => x.IsAvailable);
        }
    }
}
