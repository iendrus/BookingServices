using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Recipients.Queries.GetRecipients
{
    public class GetRecipientsQueryHandler : IRequestHandler<GetRecipientsQuery, RecipientsVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetRecipientsQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<RecipientsVm> Handle(GetRecipientsQuery request, CancellationToken cancellationToken)
        {
            var recipientsQuery = _context.Recipients
                .Where(x => x.IsActive == 1);

            if (request.Id != null) 
            {
                recipientsQuery = recipientsQuery.Where(x => x.Id == request.Id);
            }

            if (!string.IsNullOrEmpty(request.EmailAddress))
            {
                var email = Email.For(request.EmailAddress);
                recipientsQuery = recipientsQuery
                     .Where(x => x.Email.UserName == email.UserName && x.Email.DomainName == email.DomainName);
            }
            var recipients = await recipientsQuery
                .AsNoTracking().ProjectTo<RecipientsDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new RecipientsVm() { Recipients = recipients };
        }
    }
}
