using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Industries.Queries.GetIndustries
{
    public class GetIndustriesQueryHandler : IRequestHandler<GetIndustriesQuery, IndustriesVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        private readonly IcurrentUserService _userService;
        public GetIndustriesQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper,IcurrentUserService userService)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
            _userService = userService;
        }
        public async Task<IndustriesVm> Handle(GetIndustriesQuery request, CancellationToken cancellationToken)
        {
            var industriesQuery = _context.Industries
                .Where(x => x.IsActive == 1);

            if (!string.IsNullOrEmpty(request.Name))
            {
                industriesQuery = industriesQuery.Where(x => x.Name.Contains(request.Name));
            }
            if (!string.IsNullOrEmpty(request.Description))
            {
                industriesQuery = industriesQuery.Where(x => x.Description.Contains(request.Description));
            }

            var industries = await industriesQuery
                .AsNoTracking().ProjectTo<IndustriesDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new IndustriesVm() { Industries = industries };
        }
    }
}
