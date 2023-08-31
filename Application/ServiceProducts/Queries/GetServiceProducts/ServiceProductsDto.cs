using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.ServiceProducts.Queries.GetServiceProducts
{
    public class ServiceProductsDto : IMapFrom<ServiceProduct>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceProviderName { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<ServiceProduct, ServiceProductsDto>();
        }

    }
}
