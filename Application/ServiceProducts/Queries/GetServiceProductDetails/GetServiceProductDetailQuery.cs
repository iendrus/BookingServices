using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProducts.Queries.GetServiceProductDetails
{
    public class GetServiceProductDetailQuery : IRequest<ServiceProductDetailVm>
    {
        public int Id { get; set; }
    }
}
