using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;



namespace BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider
{
    public class CreateServiceProviderCommandHandler : IRequestHandler<CreateServiceProviderCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreateServiceProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceProviderCommand request, CancellationToken cancellationToken)
        {
            var serviceProvider = _mapper.Map<ServiceProvider>(request);

            _context.ServiceProviders.Add(serviceProvider);
            await _context.SaveChangesAsync(cancellationToken);
            return serviceProvider.Id;
        }
    }
}
