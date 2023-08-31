using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class ServiceProductConfiguration : IEntityTypeConfiguration<ServiceProduct>
    {

        public void Configure(EntityTypeBuilder<ServiceProduct> builder)
        {

            //// --- configure one-to-many 
            builder
                .HasMany(x => x.ServicePerformances)
                .WithOne(x => x.ServiceProduct)
                .HasForeignKey(x => x.ServiceProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
        }
    }
}
