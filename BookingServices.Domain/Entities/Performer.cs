using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;


namespace BookingServices.Domain.Entities
{
    public class Performer : AuditableEntity
    {
        public PersonName FullName { get; set; }
        public Email Email { get; set; }
        public string? Phone { get; set; }
        public Provider Provider { get; set; }
        public int ProviderId { get; set; }
        public List<ProductPerformer> ProductPerformers { get; private set; } = new ();
        public List<Offer> Offers { get; private set; } = new();
    }
}
