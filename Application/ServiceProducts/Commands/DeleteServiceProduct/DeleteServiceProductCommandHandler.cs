using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.ServiceProducts.Commands.DeleteServiceProduct
{
    public class DeleteServiceProductCommandHandler : IRequestHandler<DeleteServiceProductCommand>
    {
        private readonly IBookingServicesDbContext _context;
        public DeleteServiceProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }

        public async Task Handle(DeleteServiceProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.ServiceProducts.Where(s => s.Id == request.Id && s.IsActive == true)
               .FirstOrDefaultAsync(cancellationToken);
            if (product != null)
            {
                _context.ServiceProducts.Remove(product);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
