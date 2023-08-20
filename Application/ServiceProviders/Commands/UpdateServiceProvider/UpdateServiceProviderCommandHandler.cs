using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookingServices.Application.ServiceProviders.Commands.UpdateServiceProvider
{
    public class UpdateServiceProviderCommandHandler : IRequestHandler<UpdateServiceProviderCommand, int>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public UpdateServiceProviderCommandHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateServiceProviderCommand request, CancellationToken cancellationToken)
        {
            var serviceProvider = await _context.ServiceProviders.Where(x => x.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (serviceProvider != null)
            {
                _mapper.Map(request, serviceProvider);
                await _context.SaveChangesAsync(cancellationToken);
                return serviceProvider.Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
