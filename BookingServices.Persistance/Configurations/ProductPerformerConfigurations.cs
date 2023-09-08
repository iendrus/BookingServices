using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BookingServices.Persistance.Configurations
{
    public class ProductPerformerConfigurations : IEntityTypeConfiguration<ProductPerformer>
    {
        public void Configure(EntityTypeBuilder<ProductPerformer> builder)
        {
            builder
                .HasOne(spp => spp.Product)
                .WithMany(sp => sp.ProductPerformers)
                .HasForeignKey(spp => spp.ProductId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(spp => spp.Performer)
                .WithMany(pp => pp.ProductPerformers)
                .HasForeignKey(spp => spp.PerformerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
