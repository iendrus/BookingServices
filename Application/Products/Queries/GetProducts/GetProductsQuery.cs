using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<ProductsVm>
    {
        public string? Name { get; set; }
        public string? ProviderName { get; set; }
    }
}
