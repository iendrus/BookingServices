using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Persistance
{
    public class BookingServicesDbContextFactory : DesignTimeDbContextFactoryBase<BookingServicesDbContext>
    {
        protected override BookingServicesDbContext CreateNewInstance(DbContextOptions<BookingServicesDbContext> options)
        {
            return new BookingServicesDbContext(options);
        }
    }
}
