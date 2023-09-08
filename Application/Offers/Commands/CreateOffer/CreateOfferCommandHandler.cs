using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Offers.Commands.CreateOffer
{
    public class CreateOfferCommandHandler : IRequestHandler<CreateOfferCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreateOfferCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
        {
            var offer = _mapper.Map<Offer>(request);
            _context.Offers.Add(offer);
            await _context.SaveChangesAsync(cancellationToken);
            return offer.Id;
        }
    }
}
