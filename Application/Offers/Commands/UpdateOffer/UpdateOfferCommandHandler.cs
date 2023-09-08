using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.Offers.Commands.UpdateOffer
{
    public class UpdateOfferCommandHandler : IRequestHandler<UpdateOfferCommand>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateOfferCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task Handle(UpdateOfferCommand request, CancellationToken cancellationToken)
        {
            var offer = await _context.Offers
                .Where(x => x.Id == request.Id && x.IsActive == true).FirstOrDefaultAsync(cancellationToken);
            if (offer == null)
            {
                throw new IsNullException();
            }

            _mapper.Map(request, offer);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
