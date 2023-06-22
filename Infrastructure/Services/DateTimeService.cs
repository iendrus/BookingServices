using BookingServices.Application.Common.Interfaces;


namespace BookingServices.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
