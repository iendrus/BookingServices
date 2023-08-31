using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Industries.Queries.GetIndustryDetails
{
    public class GetIndustryDetailQueryHandler : IRequestHandler<GetIndustryDetailQuery, IndustryDetailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetIndustryDetailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;
        }
        public async Task<IndustryDetailVm> Handle(GetIndustryDetailQuery request, CancellationToken cancellationToken)
        {

            var industry = _context.Industries.Where(s => s.Id == request.Id && s.IsActive == true);

            if (industry != null)
            {
                var industryVm = await industry
                    .AsNoTracking().ProjectTo<IndustryDetailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return industryVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
