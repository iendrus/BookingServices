using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider
{
    public class DeleteServiceProviderCommandHandler : IRequestHandler<DeleteServiceProviderCommand>
    {
        private readonly IBookingServicesDbContext _context;
        public DeleteServiceProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }

        public async Task Handle(DeleteServiceProviderCommand request, CancellationToken cancellationToken)
        {
            var serviceProvider = await _context.ServiceProviders.Where(s => s.Id == request.ServiceProviderId )
               .FirstOrDefaultAsync(cancellationToken);

            _context.ServiceProviders.Remove(serviceProvider);
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
