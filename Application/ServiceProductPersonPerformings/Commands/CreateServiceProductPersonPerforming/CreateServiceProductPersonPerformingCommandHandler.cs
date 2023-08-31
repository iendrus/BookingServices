using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.ServiceProductPersonPerformings.Commands.CreateServiceProductPersonPerforming
{
    public class UpdateProductCommandHandler : IRequestHandler<CreateServiceProductPersonPerformingCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        public UpdateProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }
        public async Task<int> Handle(CreateServiceProductPersonPerformingCommand request, CancellationToken cancellationToken)
        {
            PersonPerforming personPerforming = await _context.PersonPerformings
                .Where(p => p.Id == request.PersonPerformingId && p.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);
            if (personPerforming != null)
            {
                var serviceProductPersonPerforming = await _context.ServiceProducts
                .Where(s => s.Id == request.ServiceProductId
                && s.ServiceProvider.Id == personPerforming.ServiceProviderId // produkty tylko oferowane przez Providera
                && s.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);

                if (serviceProductPersonPerforming != null)
                { 
                    serviceProductPersonPerforming.PersonPerformings.Add(personPerforming);
                    await _context.SaveChangesAsync(cancellationToken);
                    return 1;
                }
            }
            return 0;
        }
    }
}
