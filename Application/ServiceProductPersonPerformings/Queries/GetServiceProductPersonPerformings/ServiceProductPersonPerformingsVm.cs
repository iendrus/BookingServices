using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProductPersonPerformings.Queries.GetServiceProductPersonPerformings
{
    public class ServiceProductPersonPerformingsVm
    {
        public ICollection<ServiceProductPersonPerformingsDto> ServiceProductPersonPerformings { get; set; }
    }
}
