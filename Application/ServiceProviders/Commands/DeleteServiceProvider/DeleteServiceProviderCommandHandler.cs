using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider
{
    public class DeleteServiceProviderCommandHandler
    {


        private readonly IBookingServicesDbContext _context;
        public DeleteServiceProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }
        public async Task<Unit> Handle(DeleteServiceProviderCommand request, CancellationToken cancellationToken)
        {
            var serviceProvider = await _context.ServiceProviders.Where(s => s.Id == request.ServiceProviderId)
                .FirstOrDefaultAsync(cancellationToken);

            _context.ServiceProviders.Remove(serviceProvider);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;

        }
    }
}
