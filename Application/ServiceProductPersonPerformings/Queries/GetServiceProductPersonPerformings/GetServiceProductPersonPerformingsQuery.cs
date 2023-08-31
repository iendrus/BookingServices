using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProductPersonPerformings.Queries.GetServiceProductPersonPerformings
{
    public class GetServiceProductPersonPerformingsQuery : IRequest<ServiceProductPersonPerformingsVm>
    {
        public string? PersonPerformingName { get; set; }
        public string? ServiceProductName { get; set; }
    }
}
