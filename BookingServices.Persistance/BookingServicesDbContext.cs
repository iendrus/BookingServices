using BookingServices.Domain.Common;
using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Persistance
{
    public class BookingServicesDbContext : DbContext
    {

        public BookingServicesDbContext(DbContextOptions<BookingServicesDbContext> options) : base(options)
        {

        }


        public DbSet<Service> Services { get; set; }
        public DbSet<PersonPerforming> PersonPerformings { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        public DbSet<ServicePerformance> ServicePerformances { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<ServiceRecipient> ServiceRecipients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<PersonPerforming>().OwnsOne(p => p.FullName);
            modelBuilder.Entity<ServiceProvider>().OwnsOne(p => p.Email);
            modelBuilder.Entity<ServiceProvider>().OwnsOne(p => p.ContactPerson);
            modelBuilder.Entity<PersonPerforming>().OwnsOne(p => p.Email);
            modelBuilder.Entity<ServiceRecipient>().OwnsOne(p => p.FullName);
            modelBuilder.Entity<ServiceRecipient>().OwnsOne(p => p.Email);
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
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
