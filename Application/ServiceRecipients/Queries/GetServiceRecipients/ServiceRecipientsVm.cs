using System;

namespace BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipients
{
    public class ServiceRecipientsVm
    {
        public ICollection<ServiceRecipientsDto> ServiceRecipients { get; set; }
    }
}
