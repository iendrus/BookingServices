using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Recipients.Queries.GetRecipients
{
    public class GetRecipientsQuery : IRequest<RecipientsVm>
    {
        public int? Id { get; set; }
        public string? EmailAddress { get; set; }
    }
}
