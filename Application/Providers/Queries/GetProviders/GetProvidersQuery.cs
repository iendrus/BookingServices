using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Providers.Queries.GetProviders
{
    public class GetProvidersQuery : IRequest<ProvidersVm>
    {
        public int? IndustryId { get; set; }
        public string? City { get; set; }
        public string? Name { get; set; }
    }
}
