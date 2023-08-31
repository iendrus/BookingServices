using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProducts.Queries.GetServiceProducts
{
    public class ServiceProductsVm
    {
        public ICollection<ServiceProductsDto> ServiceProducts { get; set; }
    }
}
