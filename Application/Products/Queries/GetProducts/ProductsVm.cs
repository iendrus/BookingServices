using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Products.Queries.GetProducts
{
    public class ProductsVm
    {
        public ICollection<ProductsDto> Products { get; set; }
    }
}
