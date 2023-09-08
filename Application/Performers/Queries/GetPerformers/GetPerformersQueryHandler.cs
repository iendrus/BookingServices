using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Performers.Queries.GetPerformers
{
    public class GetPerformersQueryHandler : IRequestHandler<GetPerformersQuery, PerformersVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetPerformersQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<PerformersVm> Handle(GetPerformersQuery request, CancellationToken cancellationToken)
        {
            var performersQuery = _context.Performers
                .Where(x => x.IsActive == true);

            if (request.ProviderId != null) 
            {
                performersQuery = performersQuery.Where(x => x.Provider.Id == request.ProviderId);
            }

            if (!string.IsNullOrEmpty(request.FullName))
            {
                performersQuery = performersQuery
                    .Where(x => x.FullName.FirstName.Contains((request.FullName))
                    || x.FullName.LastName.Contains((request.FullName)));
            }
            var performers = await performersQuery
                .AsNoTracking().ProjectTo<PerformersDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new PerformersVm() { Performers = performers };
        }
    }
}
