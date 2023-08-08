using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Persistance.Configurations
{
    public class ServicePerformanceConfiguration : IEntityTypeConfiguration<ServicePerformance>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ServicePerformance> builder)
        {
            builder.Property(p => p.IsFinished)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
