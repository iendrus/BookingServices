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
            var serviceProvidersQuery = _context.ServiceProviders
                .Where(x => x.IsActive == true);

            if (request.IndustryId != null) 
            {
                serviceProvidersQuery = serviceProvidersQuery.Where(x => x.Industry.Id == request.IndustryId);
            }
            if (!string.IsNullOrEmpty(request.City))
            {
                serviceProvidersQuery = serviceProvidersQuery.Where(x => x.Address.City.StartsWith(request.City));
            }
            if (!string.IsNullOrEmpty(request.Name))
            {
                serviceProvidersQuery = serviceProvidersQuery.Where(x => x.Name.StartsWith(request.Name));
            }
            var serviceProviders = await serviceProvidersQuery
                .AsNoTracking().ProjectTo<ServiceProvidersDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new ServiceProvidersVm() { ServiceProviders = serviceProviders };
        }
    }
}
