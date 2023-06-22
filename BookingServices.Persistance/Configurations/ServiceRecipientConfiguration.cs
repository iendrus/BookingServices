using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingServices.Persistance.Configurations
{
    public class ServiceRecipientConfiguration : IEntityTypeConfiguration<ServiceRecipient>
    {
        public void Configure(EntityTypeBuilder<ServiceRecipient> builder)
        {
            builder.OwnsOne(p => p.Email).Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.Email).Property(p => p.DomainName)
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.FullName).Property(p => p.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.FullName).Property(p => p.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.Phone).HasMaxLength(20);
        }
    }
}
