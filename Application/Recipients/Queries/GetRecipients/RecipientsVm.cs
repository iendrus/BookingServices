using System;

namespace BookingServices.Application.Recipients.Queries.GetRecipients
{
    public class RecipientsVm
    {
        public ICollection<RecipientsDto> Recipients { get; set; }
    }
}
