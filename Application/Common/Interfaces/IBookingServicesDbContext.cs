using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;



namespace BookingServices.Application.Common.Interfaces
{
    public interface IBookingServicesDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Performer> Performers { get; set; }
        DbSet<Provider> Providers { get; set; }
        DbSet<Offer> Offers { get; set; }
        DbSet<Industry> Industries { get; set; }
        DbSet<Recipient> Recipients { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<ProductPerformer> ProductPerformers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
