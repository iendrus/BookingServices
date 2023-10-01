using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class BookingConfiguration : BaseEntityConfiguration<Booking>
    {
        public override void Configure(EntityTypeBuilder<Booking> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.RecipientId).IsRequired();
            builder.Property(x => x.State).IsRequired();
            builder.Property(x => x.Cost).HasPrecision(9, 2).IsRequired();
            builder.HasIndex(x => x.State);
        }
    }
}
