using System;

namespace BookingServices.Application.Bookings.Queries.GetBookings
{
    public class BookingsVm
    {
        public ICollection<BookingsDto> Bookings { get; set; }
    }
}
