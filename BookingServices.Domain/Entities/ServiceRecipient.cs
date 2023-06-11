using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;

namespace BookingServices.Domain.Entities
{
    public class ServiceRecipient : AuditableEntity
    {
        public PersonName FullName { get; set; }
        public Email Email { get; set; }
        public string? Phone { get; set; }
        public List<ServicePerformance> ServicePerformances { get; private set; } = new ();

    }
}
