using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Industries.Queries.GetIndustries
{
    public class IndustriesVm
    {
        public ICollection<IndustriesDto> Industries { get; set; }
    }
}
