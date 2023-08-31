using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipientDetail;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;



namespace BookingServices.Application.ServiceProducts.Queries.GetServiceProductDetails
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetServiceProductDetailQuery, ServiceProductDetailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetProductDetailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<ServiceProductDetailVm> Handle(GetServiceProductDetailQuery request, CancellationToken cancellationToken)
        {
            var serviceProduct = _context.ServiceProducts.Where(s => s.Id == request.Id && s.IsActive == true)
               .Include(s => s.ServiceProvider);

            if (serviceProduct != null)
            {
                var serviceProductVm = await serviceProduct
                    .AsNoTracking().ProjectTo<ServiceProductDetailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return serviceProductVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
