using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.PersonPerformings.Queries.GetPersonPerformings
{
    public class GetPersonPerformingsQueryHandler : IRequestHandler<GetPersonPerformingsQuery, PersonPerformingsVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetPersonPerformingsQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<PersonPerformingsVm> Handle(GetPersonPerformingsQuery request, CancellationToken cancellationToken)
        {
            var personPerformingsQuery = _context.PersonPerformings
                .Where(x => x.IsActive == true);

            if (request.ServiceProviderId != null) 
            {
                personPerformingsQuery = personPerformingsQuery.Where(x => x.ServiceProvider.Id == request.ServiceProviderId);
            }

            if (!string.IsNullOrEmpty(request.FullName))
            {
                personPerformingsQuery = personPerformingsQuery
                    .Where(x => x.FullName.FirstName.Contains((request.FullName))
                    || x.FullName.LastName.Contains((request.FullName)));
            }
            var personPerformings = await personPerformingsQuery
                .AsNoTracking().ProjectTo<PersonPerformingsDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new PersonPerformingsVm() { PersonPerformings = personPerformings };
        }
    }
}
