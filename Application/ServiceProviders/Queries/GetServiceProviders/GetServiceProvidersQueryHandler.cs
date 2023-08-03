using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviders
{
    public class GetServiceProvidersQueryHandler : IRequestHandler<GetServiceProvidersQuery, ServiceProvidersVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetServiceProvidersQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ServiceProvidersVm> Handle(GetServiceProvidersQuery request, CancellationToken cancellationToken)
        {
            var serviceProviders = await _context.ServiceProviders
                .Where(x => x.IsActive == true)
                .AsNoTracking().ProjectTo<ServiceProvidersDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new ServiceProvidersVm() { ServiceProviders = serviceProviders };
        }
    }
}
