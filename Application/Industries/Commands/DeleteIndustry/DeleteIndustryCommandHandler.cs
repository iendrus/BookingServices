using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookingServices.Application.Industries.Commands.DeleteIndustry
{
    public class DeleteIndustryCommandHandler : IRequestHandler<DeleteIndustryCommand>
    {
        private readonly IBookingServicesDbContext _context;
        public DeleteIndustryCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;

        }

        public async Task Handle(DeleteIndustryCommand request, CancellationToken cancellationToken)
        {
            var industry = await _context.Industries.Where(s => s.Id == request.Id && s.IsActive == true)
               .FirstOrDefaultAsync(cancellationToken);
            if (industry != null)
            {
                _context.Industries.Remove(industry);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
