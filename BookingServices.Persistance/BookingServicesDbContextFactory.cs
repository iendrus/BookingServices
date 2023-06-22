using BookingServices.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace BookingServices.Persistance
{
    public class BookingServicesDbContextFactory : DesignTimeDbContextFactoryBase<BookingServicesDbContext>
    {
        private IDateTime dateTime;
        protected override BookingServicesDbContext CreateNewInstance(DbContextOptions<BookingServicesDbContext> options)
        {
            return new BookingServicesDbContext(options, dateTime);
        }
    }
}
