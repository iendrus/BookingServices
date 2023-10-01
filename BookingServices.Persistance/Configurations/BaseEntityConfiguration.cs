using BookingServices.Domain.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Persistance.Configurations
{
    public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : AuditableEntity 
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasIndex(x => x.IsActive);
            builder.Property(x => x.CreatedBy).HasMaxLength(255).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(255);
        }
    }
}
