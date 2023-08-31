using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProducts.Queries.GetServiceProducts
{
    public class GetServiceProductsQuery : IRequest<ServiceProductsVm>
    {
        public string? Name { get; set; }
        public string? ServiceProviderName { get; set; }
    }
}
