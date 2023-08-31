using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.ServiceProducts.Queries.GetServiceProducts
{
    public class GetServiceProductsQueryHandler : IRequestHandler<GetServiceProductsQuery, ServiceProductsVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetServiceProductsQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ServiceProductsVm> Handle(GetServiceProductsQuery request, CancellationToken cancellationToken)
        {
            var serviceProductsQuery = _context.ServiceProducts
                .Where(x => x.IsActive == true);

            if (!string.IsNullOrEmpty(request.Name))
            {
                serviceProductsQuery = serviceProductsQuery.Where(x => x.Name.Contains(request.Name));
            }
            if (!string.IsNullOrEmpty(request.ServiceProviderName))
            {
                serviceProductsQuery = serviceProductsQuery.Where(x => x.ServiceProvider.Name.Contains(request.ServiceProviderName));
            }

            var serviceProducts = await serviceProductsQuery
                .AsNoTracking().ProjectTo<ServiceProductsDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new ServiceProductsVm() { ServiceProducts = serviceProducts };
        }
    }
}
