using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookingServices.Application.Common.Exceptions;
using BookingServices.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace BookingServices.Application.Bookings.Queries.GetBookingDetail
{
    public class GetBookingDatailQueryHandler : IRequestHandler<GetBookingDatailQuery, BookingDatailVm>
    {
        private readonly IBookingServicesDbContext _context;
        private readonly IMapper _mapper;
        public GetBookingDatailQueryHandler(IBookingServicesDbContext bookingServicesDbContext, IMapper mapper)
        {
            _context = bookingServicesDbContext;
            _mapper = mapper;

        }
        public async Task<BookingDatailVm> Handle(GetBookingDatailQuery request, CancellationToken cancellationToken)
        {
            var booking = _context.Bookings
                .Where(p => p.Id == request.Id && p.IsActive == 1);
            if (booking == null)
            {
                throw new IsNullException();
            }

            var bookingVm = await booking
                .AsNoTracking().ProjectTo<BookingDatailVm>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
            return bookingVm;
        }
    }
}
