using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace BookingServices.Persistance.Configurations
{
    public class PersonPerformingConfiguration : IEntityTypeConfiguration<PersonPerforming>
    {
        public void Configure(EntityTypeBuilder<PersonPerforming> builder)
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

            //--configure many - to - many
            builder
                .HasMany(p => p.Services)
                .WithMany(s => s.PersonPerformings)
                .UsingEntity<Dictionary<string, object>>(
                    "ServicePersonPerforming",
                x => x
                    .HasOne<Service>()
                    .WithMany()
                    .HasForeignKey("ServicesId")
                    .OnDelete(DeleteBehavior.Restrict),
                x => x
                    .HasOne<PersonPerforming>()
                    .WithMany()
                    .HasForeignKey("PersonPerformingsId")
                    .OnDelete(DeleteBehavior.Restrict)
                );

        }
    }
}
