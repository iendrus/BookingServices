using BookingServices.Domain.Common;


namespace BookingServices.Domain.Entities
{
    public class ServicePerformance : AuditableEntity
    {
        public int ServiceRecipientId { get; set; }
        public int PersonPerformingId { get; set; }
        public int ServiceId { get; set; }
        public int StatusId { get; set; }
        public string? ServiceRecipientComments { get; set; }
        public DateTime StartOfService{ get; set; }
        public DateTime EndOfService { get; set; }
        public Service Service { get; set; } 
        public ServiceRecipient ServiceRecipient { get; set; }
        public PersonPerforming PersonPerforming { get; set; }

    }
}
