using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail
{
    public class GetServiceProviderDatailQueryHandler : IRequestHandler<GetServiceProviderDatailQuery, ServiceProviderDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetServiceProviderDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ServiceProviderDatailVm> Handle(GetServiceProviderDatailQuery request, CancellationToken cancellationToken)
        {
            var serviceProvider = await _context.ServiceProviders.Where(s => s.Id == request.ServiceProviderId)
                .FirstOrDefaultAsync(cancellationToken);

            var serviceProviderVm = _mapper.Map<ServiceProviderDatailVm>(serviceProvider); 

            return serviceProviderVm;
        }
    }
}
