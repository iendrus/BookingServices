using AutoMapper;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.ProductPerformers.Commands.CreateProductPerformer
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductPerformerCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateProductPerformerCommand request, CancellationToken cancellationToken)
        {
            if (!await IsProductExistsFromPerformerProvider(request.PerformerId, request.ProductId,cancellationToken))
            {
                throw new NotExistsProductPerformerException();
            }

            var productPerformer = _mapper.Map<ProductPerformer>(request);

            _context.ProductPerformers.Add(productPerformer);
            await _context.SaveChangesAsync(cancellationToken);
            return 0;
        }

        private async Task<bool> IsProductExistsFromPerformerProvider(int performerId, int productId, CancellationToken cancellationToken)
        {
            bool result = await _context.Products
                .AnyAsync(p => p.Provider.Performers.Any(p => p.Id == performerId) && p.Id == productId
                    && p.IsActive == 1, cancellationToken);
            return result;
        }

    }
}
