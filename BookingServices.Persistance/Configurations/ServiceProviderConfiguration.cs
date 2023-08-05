using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class ServiceProviderConfiguration : IEntityTypeConfiguration<ServiceProvider>
    {
        public void Configure(EntityTypeBuilder<ServiceProvider> builder)
        {
            builder.OwnsOne(p => p.Email).Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.Email).Property(p => p.DomainName)
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.ContactPerson).Property(p => p.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.ContactPerson).Property(p => p.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.Address).Property(p => p.City)
                .HasColumnName("City")
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.Address).Property(p => p.Street)
                .HasColumnName("Street")
                .HasMaxLength(100);
            builder.OwnsOne(p => p.Address).Property(p => p.ZipCode)
                .HasColumnName("ZipCode")
                .IsRequired()
                .HasMaxLength(10);
            builder.OwnsOne(p => p.Address).Property(p => p.Number)
                .HasColumnName("Number")
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(p=>p.Nip).HasMaxLength(20);
            builder.Property(p=>p.Phone).HasMaxLength(20);
            builder.Property(p=>p.Name).HasMaxLength(255).IsRequired();
        }
    }
}
