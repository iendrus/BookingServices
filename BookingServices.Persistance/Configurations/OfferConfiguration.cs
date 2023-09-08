using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.Property(x => x.PerformerId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.Cost).HasPrecision(9, 2);
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

        }
    }
}
