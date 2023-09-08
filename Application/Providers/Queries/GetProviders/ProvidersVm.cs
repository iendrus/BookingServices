using System;

namespace BookingServices.Application.Providers.Queries.GetProviders
{
    public class ProvidersVm
    {
        public ICollection<ProvidersDto> Providers { get; set; }
    }
}
