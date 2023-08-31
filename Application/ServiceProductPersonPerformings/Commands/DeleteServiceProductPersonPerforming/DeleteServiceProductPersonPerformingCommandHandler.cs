using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.ServiceProductPersonPerformings.Commands.DeleteServiceProductPersonPerforming
{
    public class DeleteServiceProductPersonPerformingCommandHandler : IRequestHandler<DeleteServiceProductPersonPerformingCommand>
    {
        private readonly IBookingServicesDbContext _context;
        public DeleteServiceProductPersonPerformingCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }

        public async Task Handle(DeleteServiceProductPersonPerformingCommand request, CancellationToken cancellationToken)
        {
            var serviceProductPersonPerforming = await _context.ServiceProducts
                .Include(s => s.PersonPerformings)
                .Where(s => s.Id == request.ServiceProductId && s.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);
            if (serviceProductPersonPerforming != null)
            {
                var personPerforming = serviceProductPersonPerforming.PersonPerformings
                    .FirstOrDefault(p => p.Id == request.PersonPerformingId && p.IsActive == true);
                if (personPerforming != null)
                {
                    serviceProductPersonPerforming.PersonPerformings.Remove(personPerforming);
                    await _context.SaveChangesAsync(cancellationToken);
                }
            }
        }
    }
}
