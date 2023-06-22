using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Persistance.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {

        public void Configure(EntityTypeBuilder<Service> builder)
        {

            //// --- configure one-to-many 
            builder
                .HasMany(x => x.ServicePerformances)
                .WithOne(x => x.Service)
                .HasForeignKey(x => x.ServiceId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
