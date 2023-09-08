using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;


namespace BookingServices.Domain.Entities
{
    public class Provider : AuditableEntity
    {
        public string Name { get; set; }
        public string? Nip { get; set; }
        public Address Address { get; set; }
        public PersonName ContactPerson { get; set; }
        public Email Email { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public int IndustryId { get; set; }

        public Industry Industry { get; set; }
        public List<Performer> Performers { get; private set; } = new();
        public List<Product> Products { get; private set; } = new();
    }
}
