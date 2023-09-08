using BookingServices.Domain.Common;


namespace BookingServices.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
        public List<ProductPerformer> ProductPerformers { get; private set; } = new List<ProductPerformer>();
        public List<Offer> Offers { get; private set; } = new List<Offer>();
        public List<Booking> Bookings { get; private set; } = new List<Booking>();
    }
}
