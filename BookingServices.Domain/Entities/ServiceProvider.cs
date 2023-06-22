using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;


namespace BookingServices.Domain.Entities
{
    public class ServiceProvider : AuditableEntity
    {
        public string Name { get; set; }
        public string? Nip { get; set; }
        public PersonName ContactPerson { get; set; }
        public Email Email { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public List<PersonPerforming> PersonPerformings { get; private set; } = new();
        public List<Service> Services { get; private set; } = new();
    }
}
