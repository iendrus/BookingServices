using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Bookings.Queries.GetBookings
{
    public class GetBookingsQuery : IRequest<BookingsVm>
    {
        public int? PerformerId { get; set; }
        public int? ProviderId { get; set; }
        public int? ProductId { get; set; }
        public int? RecipientId { get; set; }
        public string? RecipientEmailAddress { get; set; }
        public string? RecipientPhoneNumber { get; set; }
        public string? ProviderName { get; set; }
        public string? ProductName { get; set; }
        public BookingState State { get; set; }
        public DateTime? StartOfServiceFrom { get; set; }
        public DateTime? StartOfServiceTo { get; set; }
    }
}
