using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipientDetail
{
    public class GetServiceRecipientDatailQuery : IRequest<ServiceRecipientDatailVm>
    {
        public int Id { get; set; }
    }
}
