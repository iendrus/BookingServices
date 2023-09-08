using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Offers.Commands.DeleteOffer
{
    public class DeleteOfferCommandHandler : IRequestHandler<DeleteOfferCommand>
    {

        private readonly IBookingServicesDbContext _context;
        public DeleteOfferCommandHandler(IBookingServicesDbContext bookingServicesDbContext)
        {
            _context = bookingServicesDbContext;
        }

        public async Task Handle(DeleteOfferCommand request, CancellationToken cancellationToken)
        {
            var offer = await _context.Offers
               .Where(s => s.Id == request.Id && s.IsActive == true).FirstOrDefaultAsync(cancellationToken);

            if (offer == null)
            {
                throw new IsNullException();
            }

             _context.Offers.Remove(offer);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
