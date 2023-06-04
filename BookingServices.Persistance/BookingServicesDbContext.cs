using BookingServices.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Persistance
{
    public class BookingServicesDbContext : DbContext
    {

        public BookingServicesDbContext(DbContextOptions<BookingServicesDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = 1;
                        entry.Entity.CreatedAt = DateTime.Now;
                        entry.Entity.IsActive = true;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = 1;
                        entry.Entity.ModifiedAt = DateTime.Now;
                        break;
                    case EntityState.Detached:
                        entry.Entity.ModifiedBy = 1;
                        entry.Entity.ModifiedAt = DateTime.Now;
                        entry.Entity.IsActive = false;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
