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

namespace BookingServices.Application.Providers.Queries.GetProviders
{
    public class GetProvidersQueryHandler : IRequestHandler<GetProvidersQuery, ProvidersVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetProvidersQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ProvidersVm> Handle(GetProvidersQuery request, CancellationToken cancellationToken)
        {
            var providersQuery = _context.Providers
                .Where(x => x.IsActive == true);

            if (request.IndustryId != null) 
            {
                providersQuery = providersQuery.Where(x => x.Industry.Id == request.IndustryId);
            }
            if (!string.IsNullOrEmpty(request.City))
            {
                providersQuery = providersQuery.Where(x => x.Address.City.StartsWith(request.City));
            }
            if (!string.IsNullOrEmpty(request.Name))
            {
                providersQuery = providersQuery.Where(x => x.Name.StartsWith(request.Name));
            }
            var providers = await providersQuery
                .AsNoTracking().ProjectTo<ProvidersDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new ProvidersVm() { Providers = providers };
        }
    }
}
