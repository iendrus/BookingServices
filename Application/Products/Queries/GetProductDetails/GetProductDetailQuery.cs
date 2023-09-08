using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Products.Queries.GetProductDetails
{
    public class GetProductDetailQuery : IRequest<ProductDetailVm>
    {
        public int Id { get; set; }
    }
}
