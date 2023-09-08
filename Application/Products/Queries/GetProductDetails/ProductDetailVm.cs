using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.Products.Queries.GetProductDetails
{
    public class ProductDetailVm : IMapFrom<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDetailVm>();
        }
    }
}
