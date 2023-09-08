using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Performers.Queries.GetPerformers
{
    public class GetPerformersQuery : IRequest<PerformersVm>
    {
        public int? ProviderId { get; set; }
        public string? FullName { get; set; }
    }
}
