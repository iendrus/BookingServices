using BookingServices.Domain.Entities;


namespace BookingServices.Application.Bookings.Queries.GetBookings
{
    public class GetBookingsRequest
    {
        public int? performerId { get; set; }
        public int? providerId { get; set; }
        public int? productId { get; set; }
        public int? recipientId { get; set; }
        public string? recipientEmailAddress { get; set; }
        public string? recipientPhoneNumber { get; set; }
        public string? providerName { get; set; }
        public string? productName { get; set; }
        public BookingState? state { get; set; }
        public DateTime? startOfServiceFrom { get; set; }
        public DateTime? startOfServiceTo { get; set; }
    }
}
