using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.ServiceProducts.Queries.GetServiceProductDetails
{
    public class ServiceProductDetailVm : IMapFrom<ServiceProduct>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceProviderName { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ServiceProduct, ServiceProductDetailVm>();
        }
    }
}
