using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.Products.Queries.GetProducts
{
    public class ProductsDto : IMapFrom<Product>
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<Product, ProductsDto>();
        }

    }
}
