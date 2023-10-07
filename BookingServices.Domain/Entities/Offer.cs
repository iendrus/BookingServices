using BookingServices.Domain.Common;


namespace BookingServices.Domain.Entities
{
    public class Offer : AuditableEntity
    {
        public int PerformerId { get; set; }
        public int ProductId { get; set; }
        public decimal Cost { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime StartOfService{ get; set; }
        public DateTime EndOfService { get; set; }
        public Product Product { get; set; } 
        public Performer Performer { get; set; }
        public List<Booking> Bookings { get; private set; } = new ();
    }
}
