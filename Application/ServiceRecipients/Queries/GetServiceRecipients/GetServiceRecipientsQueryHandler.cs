using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipients
{
    public class GetServiceRecipientsQueryHandler : IRequestHandler<GetServiceRecipientsQuery, ServiceRecipientsVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetServiceRecipientsQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<ServiceRecipientsVm> Handle(GetServiceRecipientsQuery request, CancellationToken cancellationToken)
        {
            var serviceRecipientsQuery = _context.ServiceRecipients
                .Where(x => x.IsActive == true);

            if (request.Id != null) 
            {
                serviceRecipientsQuery = serviceRecipientsQuery.Where(x => x.Id == request.Id);
            }

            if (!string.IsNullOrEmpty(request.EmailAddress))
            {
                var email = Email.For(request.EmailAddress);
                serviceRecipientsQuery = serviceRecipientsQuery
                     .Where(x => x.Email.UserName == email.UserName && x.Email.DomainName == email.DomainName);
            }
            var serviceRecipients = await serviceRecipientsQuery
                .AsNoTracking().ProjectTo<ServiceRecipientsDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new ServiceRecipientsVm() { ServiceRecipients = serviceRecipients };
        }
    }
}
