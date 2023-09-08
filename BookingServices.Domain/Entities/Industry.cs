using BookingServices.Domain.Common;


namespace BookingServices.Domain.Entities
{
    public class Industry : AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Provider> Providers { get; private set; } = new();
    }
}
