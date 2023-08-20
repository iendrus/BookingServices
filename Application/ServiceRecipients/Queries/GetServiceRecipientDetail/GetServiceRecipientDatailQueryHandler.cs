using AutoMapper;
using BookingServices.Application.Common.Interfaces;
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
            var serviceRecipient = await _context.ServiceRecipients.Where(p => p.Id == request.Id && p.IsActive == true)
                .FirstOrDefaultAsync(cancellationToken);
            if (serviceRecipient != null)
            {
                var serviceRecipientVm = _mapper.Map<ServiceRecipientDatailVm>(serviceRecipient);
                return serviceRecipientVm;
            }
            throw new InvalidOperationException("Nie znaleziono żądanego zasobu.");
        }
    }
}
