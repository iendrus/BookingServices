using System;

namespace BookingServices.Application.Performers.Queries.GetPerformers
{
    public class PerformersVm
    {
        public ICollection<PerformersDto> Performers { get; set; }
    }
}
