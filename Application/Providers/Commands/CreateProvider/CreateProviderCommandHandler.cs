using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.Entities;
using MediatR;



namespace BookingServices.Application.Providers.Commands.CreateProvider
{
    public class CreateProviderCommandHandler : IRequestHandler<CreateProviderCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public CreateProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateProviderCommand request, CancellationToken cancellationToken)
        {
            var provider = _mapper.Map<Provider>(request);

            _context.Providers.Add(provider);
            await _context.SaveChangesAsync(cancellationToken);
            return provider.Id;
        }
    }
}
