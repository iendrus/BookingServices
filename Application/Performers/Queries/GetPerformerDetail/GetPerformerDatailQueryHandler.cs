using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.Products.Queries.GetProductDetails;
using BookingServices.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Performers.Queries.GetPerformerDetail
{
    public class GetPerformerDatailQueryHandler : IRequestHandler<GetPerformerDatailQuery, PerformerDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetPerformerDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<PerformerDatailVm> Handle(GetPerformerDatailQuery request, CancellationToken cancellationToken)
        {
            var performer = _context.Performers.Where(p => p.Id == request.Id && p.IsActive == true)
                .Include(p => p.Provider);

            if (performer != null)
            {
                var performerVm = await performer
                    .AsNoTracking().ProjectTo<PerformerDatailVm>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(cancellationToken);
                return performerVm;
            }
            throw new InvalidOperationException("Nie odnaleziono żądanego zasobu.");
        }
    }
}
