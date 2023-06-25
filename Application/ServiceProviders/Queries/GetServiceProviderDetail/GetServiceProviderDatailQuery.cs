using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail
{
    public class GetServiceProviderDatailQuery : IRequest<ServiceProviderDatailVm>
    {
        public int ServiceProviderId { get; set; }
    }
}
