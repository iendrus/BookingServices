using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace BookingServices.Persistance.Configurations
{
    public class PerformerConfiguration : IEntityTypeConfiguration<Performer>
    {
        public void Configure(EntityTypeBuilder<Performer> builder)
        {
            builder.OwnsOne(p => p.FullName).Property(p => p.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.FullName).Property(p => p.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.Email).Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(100);
            builder.OwnsOne(p => p.Email).Property(p => p.DomainName)
                .IsRequired()
            .HasMaxLength(100);
            builder.Property(p => p.Phone).HasMaxLength(20);
            //builder
            //    .HasMany(x => x.ProductPerformers)
            //    .WithOne(x => x.Performer)
            //    .HasForeignKey(x => x.PerformerId)
            //    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
