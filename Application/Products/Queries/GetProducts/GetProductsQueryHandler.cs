using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Products.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductsVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetProductsQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ProductsVm> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var productsQuery = _context.Products
                .Where(x => x.IsActive == 1);


            if (!string.IsNullOrEmpty(request.Name))
            {
                productsQuery = productsQuery.Where(x => x.Name.Contains(request.Name));
            }
            if (!string.IsNullOrEmpty(request.ProviderName))
            {
                productsQuery = productsQuery.Where(x => x.Provider.Name.Contains(request.ProviderName));
            }

            var products = await productsQuery
                .AsNoTracking().ProjectTo<ProductsDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new ProductsVm() { Products = products };
        }
    }
}
