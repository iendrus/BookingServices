using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviders
{
    public class GetServiceProvidersQuery : IRequest<ServiceProvidersVm>
    {
        public int? IndustryId { get; set; }
        public string? City { get; set; }
        public string? Name { get; set; }
    }
}
