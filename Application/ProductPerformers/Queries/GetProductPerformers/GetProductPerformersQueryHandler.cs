using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.ProductPerformers.Queries.GetProductPerformers
{
    public class GetProductPerformersQueryHandler : IRequestHandler<GetProductPerformersQuery, ProductPerformersVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetProductPerformersQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ProductPerformersVm> Handle(GetProductPerformersQuery request, CancellationToken cancellationToken)
        {
            var query = _context.ProductPerformers.AsQueryable();

            if (!string.IsNullOrEmpty(request.ProductName))
            {
                query = query.Where(x => x.Product.Name.Contains(request.ProductName));
            }
            if (!string.IsNullOrEmpty(request.PerformerName))
            {
                query = query.Where(x => x.Performer.FullName.FirstName.Contains(request.PerformerName)
                    || x.Performer.FullName.LastName.Contains(request.PerformerName));
            }
            if (!string.IsNullOrEmpty(request.ProviderName))
            {
                query = query.Where(x => x.Performer.Provider.Name.Contains(request.ProviderName));
            }
            if (request.PerformerId != null)
            {
                query = query.Where(x => x.PerformerId == request.PerformerId);
            }
            if (request.ProductId != null)
            {
                query = query.Where(x => x.ProductId == request.ProductId);
            }
            if (request.ProviderId != null)
            {
                query = query.Where(x => x.Performer.ProviderId == request.ProviderId);
            }

            var productPerformers = await query
                .AsNoTracking().ProjectTo<ProductPerformersDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new ProductPerformersVm() { ProductPerformers = productPerformers };
        }
    }
}
