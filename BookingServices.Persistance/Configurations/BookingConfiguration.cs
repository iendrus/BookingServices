using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Property(x => x.PerformerId).IsRequired();
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.RecipientId).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.Cost).HasPrecision(9, 2).IsRequired();
            builder
                .HasOne(sb => sb.Product)
                .WithMany(sp => sp.Bookings)
                .HasForeignKey(sb => sb.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(sb => sb.Performer)
                .WithMany(sp => sp.Bookings)
                .HasForeignKey(sp => sp.PerformerId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(sb => sb.Recipient)
                .WithMany(sr => sr.Bookings)
                .HasForeignKey(sb => sb.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(sr => sr.Offer)
                .WithMany(so => so.Bookings)
                .HasForeignKey(sb => sb.OfferId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
