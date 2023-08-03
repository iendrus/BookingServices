using System;

namespace BookingServices.Application.ServiceProviders.Queries.GetServiceProviders
{
    public class ServiceProvidersVm
    {
        public ICollection<ServiceProvidersDto> ServiceProviders { get; set; }
    }
}
