using AutoMapper;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.PersonPerformings.Queries.GetPersonPerformingDetail
{
    public class GetPersonPerformingDatailQueryHandler : IRequestHandler<GetPersonPerformingDatailQuery, PersonPerformingDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetPersonPerformingDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<PersonPerformingDatailVm> Handle(GetPersonPerformingDatailQuery request, CancellationToken cancellationToken)
        {
            var personPerforming = await _context.PersonPerformings.Where(p => p.Id == request.Id && p.IsActive == true)
                .Include(p => p.ServiceProvider)
                .FirstOrDefaultAsync(cancellationToken);

            var personPerformingVm = _mapper.Map<PersonPerformingDatailVm>(personPerforming); 

            return personPerformingVm;
        }
    }
}
