using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Recipients.Queries.GetRecipientDetail;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;



namespace BookingServices.Application.Products.Queries.GetProductDetails
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDetailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetProductDetailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<ProductDetailVm> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var product = _context.Products.Where(s => s.Id == request.Id && s.IsActive == 1)
               .Include(s => s.Provider);

            if (product != null)
            {
                var productVm = await product
                    .AsNoTracking().ProjectTo<ProductDetailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return productVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
