using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ServiceProducts.Commands.CreateServiceProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<CreateServiceProductCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<ServiceProduct>(request);

            _context.ServiceProducts.Add(product);
            await _context.SaveChangesAsync(cancellationToken);
            return product.Id;
        }

    }
}
