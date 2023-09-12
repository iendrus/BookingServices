using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class IndustryConfiguration : BaseEntityConfiguration<Industry>
    {
        public override void Configure(EntityTypeBuilder<Industry> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
