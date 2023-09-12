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
            
            if (!await IsTheProductPerformerExists(request.PerformerId, request.ProductId, cancellationToken))
            {
                throw new NotExistsProductPerformerException();
            }

            if (!await IsThePerformerHavaTimeAvailable(request.Id, request.PerformerId, request.StartOfService, request.EndOfService, cancellationToken))
            {
                throw new TimeRangeUnavalaibleException();
            }

            _mapper.Map(request, offer);
            await _context.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }

        private async Task<bool> IsTheProductPerformerExists(int performerId, int productId, CancellationToken cancellationToken)
        {
            bool result = await _context.ProductPerformers
                .AnyAsync(pp => pp.PerformerId == performerId && pp.ProductId == productId, cancellationToken);

            return result;
        }

        private async Task<bool> IsThePerformerHavaTimeAvailable(int offerId, int performerId, DateTime timeFrom,
            DateTime timeTo, CancellationToken cancellationToken)
        {
            bool result = await _context.Offers
                .AnyAsync(o => (o.PerformerId == performerId && o.IsActive == true && o.Id != offerId )
                && ((o.StartOfService < timeTo && o.StartOfService > timeFrom)
                || (o.EndOfService < timeTo && o.EndOfService > timeFrom)
                || (o.StartOfService <= timeFrom && o.EndOfService >= timeTo)),
                cancellationToken);

            return !result;
        }
    }
}
