using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Industries.Queries.GetIndustries
{
    public class GetIndustriesQuery : IRequest<IndustriesVm>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
