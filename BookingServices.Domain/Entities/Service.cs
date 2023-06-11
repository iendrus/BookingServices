using BookingServices.Domain.Common;


namespace BookingServices.Domain.Entities
{
    public class Service : AuditableEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int ServicePorviderId { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public List<PersonPerforming> PersonPerformings { get; private set; } = new List<PersonPerforming>();
        public List<ServicePerformance> ServicePerformances { get; private set; } = new List<ServicePerformance>();
    }
}
