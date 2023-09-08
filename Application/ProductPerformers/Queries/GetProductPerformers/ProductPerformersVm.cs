using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ProductPerformers.Queries.GetProductPerformers
{
    public class ProductPerformersVm
    {
        public ICollection<ProductPerformersDto> ProductPerformers { get; set; }
    }
}
