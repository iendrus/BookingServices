using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProducts.Queries.GetServiceProductDetails;
using BookingServices.Domain.Entities;
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
            var personPerforming = _context.PersonPerformings.Where(p => p.Id == request.Id && p.IsActive == true)
                .Include(p => p.ServiceProvider);

            if (personPerforming != null)
            {
                var personPerformingVm = await personPerforming
                    .AsNoTracking().ProjectTo<PersonPerformingDatailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return personPerformingVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
