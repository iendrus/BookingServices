using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;


namespace BookingServices.Domain.Entities
{
    public class PersonPerforming : AuditableEntity
    {
        public PersonName FullName { get; set; }
        public Email Email { get; set; }
        public string? Phone { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public int ServiceProviderId { get; set; }
        public List<ServiceProduct> ServiceProducts { get; private set; } = new();
        public List<ServicePerformance> ServicePerformances { get; private set; } = new();
    }
}
