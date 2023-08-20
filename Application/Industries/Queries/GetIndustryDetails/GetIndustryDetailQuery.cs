using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Industries.Queries.GetIndustryDetails
{
    public class GetIndustryDetailQuery : IRequest<IndustryDetailVm>
    {
        public int Id { get; set; }
    }
}
