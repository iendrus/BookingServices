using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;

namespace BookingServices.Domain.Entities
{
    public class Recipient : AuditableEntity
    {
        public PersonName FullName { get; set; }
        public Email Email { get; set; }
        public string? Phone { get; set; }
        public List<Booking> Bookings { get; private set; } = new ();

    }
}
