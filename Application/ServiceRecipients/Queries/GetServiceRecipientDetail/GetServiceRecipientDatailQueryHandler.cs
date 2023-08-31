using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipientDetail
{
    public class GetServiceRecipientDatailQueryHandler : IRequestHandler<GetServiceRecipientDatailQuery, ServiceRecipientDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetServiceRecipientDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ServiceRecipientDatailVm> Handle(GetServiceRecipientDatailQuery request, CancellationToken cancellationToken)
        {
            var serviceRecipient = _context.ServiceRecipients.Where(p => p.Id == request.Id && p.IsActive == true);
            if (serviceRecipient != null)
            {
                var serviceRecipientVm = await serviceRecipient
                    .AsNoTracking().ProjectTo<ServiceRecipientDatailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return serviceRecipientVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
