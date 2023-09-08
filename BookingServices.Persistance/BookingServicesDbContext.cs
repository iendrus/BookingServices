using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Common;
using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Threading;


namespace BookingServices.Persistance
{
    public class BookingServicesDbContext : DbContext, IBookingServicesDbContext
    {
        private readonly IDateTime _dateTime;
        public BookingServicesDbContext(DbContextOptions<BookingServicesDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<ProductPerformer> ProductPerformers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.SeedData();

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = 1;
                        entry.Entity.CreatedAt = _dateTime.Now;
                        entry.Entity.IsActive = true;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = 1;
                        entry.Entity.ModifiedAt = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = 1;
                        entry.Entity.ModifiedAt = _dateTime.Now;
                        entry.Entity.IsActive = false;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
