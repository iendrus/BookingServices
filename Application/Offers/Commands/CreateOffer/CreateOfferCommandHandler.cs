using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

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

            if (!await IsTheProductPerformerExists(request.PerformerId, request.ProductId, cancellationToken))
            {
                throw new NotExistsProductPerformerException();
            }

            if(!await IsThePerformerHavaTimeAvailable(request.PerformerId,request.StartOfService, request.EndOfService, cancellationToken))
            {
                throw new TimeRangeUnavalaibleException();
            }
            var offer = _mapper.Map<Offer>(request);
            offer.IsAvailable = true;
            _context.Offers.Add(offer);
            await _context.SaveChangesAsync(cancellationToken);
            return offer.Id;
        }

        private async Task<bool> IsTheProductPerformerExists(int performerId, int productId, CancellationToken cancellationToken)
        {
            bool result = await _context.ProductPerformers
                .AnyAsync(pp => pp.PerformerId == performerId && pp.ProductId == productId, cancellationToken);

            return result;
        }

        private async Task<bool> IsThePerformerHavaTimeAvailable(int performerId, DateTime timeFrom, DateTime timeTo, CancellationToken cancellationToken)
        {
            bool result = await _context.Offers
                .AnyAsync(pp => (pp.PerformerId == performerId && pp.IsActive == true)
                && ((pp.StartOfService < timeTo && pp.StartOfService > timeFrom)
                || (pp.EndOfService < timeTo && pp.EndOfService > timeFrom)
                || (pp.StartOfService <= timeFrom && pp.EndOfService >= timeTo)),
                cancellationToken);

            return !result;
        }


    }
}
