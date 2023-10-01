using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Common;
using BookingServices.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace BookingServices.Persistance
{
    public class BookingServicesDbContext : IdentityDbContext, IBookingServicesDbContext
    {
        private readonly IDateTime _dateTime;
        private readonly IcurrentUserService _userService;
        public BookingServicesDbContext(DbContextOptions<BookingServicesDbContext> options, IDateTime dateTime, 
            IcurrentUserService userService) : base(options)
        {
            _dateTime = dateTime;
            _userService = userService;
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
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SetRestrictOnDeleteBehavior(modelBuilder);
            modelBuilder.SeedData();
        }

        private void SetRestrictOnDeleteBehavior(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(AuditableEntity).IsAssignableFrom(entityType.ClrType))
                {
                    foreach (var foreignKey in entityType.GetForeignKeys())
                    {
                        foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
                    }
                }
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _userService.Email;
                        entry.Entity.CreatedAt = _dateTime.Now;
                        entry.Entity.IsActive = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = _userService.Email;
                        entry.Entity.ModifiedAt = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = _userService.Email;
                        entry.Entity.ModifiedAt = _dateTime.Now;
                        entry.Entity.IsActive = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
