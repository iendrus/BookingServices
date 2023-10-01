using BookingServices.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace BookingServices.Persistance
{
    public class BookingServicesDbContextFactory : DesignTimeDbContextFactoryBase<BookingServicesDbContext>
    {
        private IDateTime dateTime;
        private IcurrentUserService userService;
        protected override BookingServicesDbContext CreateNewInstance(DbContextOptions<BookingServicesDbContext> options)
        {
            return new BookingServicesDbContext(options, dateTime, userService);
        }
    }
}
