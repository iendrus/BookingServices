using BookingServices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;



namespace BookingServices.Application.Common.Interfaces
{
    public interface IBookingServicesDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<PersonPerforming> PersonPerformings { get; set; }
        DbSet<ServiceProvider> ServiceProviders { get; set; }
        DbSet<ServicePerformance> ServicePerformances { get; set; }
        DbSet<Industry> Industries { get; set; }
        DbSet<ServiceRecipient> ServiceRecipients { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
