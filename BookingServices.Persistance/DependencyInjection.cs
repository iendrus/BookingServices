using BookingServices.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Persistance
{
    public static class DependencyInjection
    {
        public static  IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookingServicesDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BookingServicesDatabase")));
            services.AddScoped<IBookingServicesDbContext, BookingServicesDbContext>();
            return services;
        }
    }
}
