using BookingServices.Domain.Common;


namespace BookingServices.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
        public List<ProductPerformer> ProductPerformers { get; private set; } = new ();
        public List<Offer> Offers { get; private set; } = new ();

    }
}
