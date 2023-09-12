using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;

namespace BookingServices.Application.ProductPerformers.Queries.GetProductPerformers
{
    public class ProductPerformersDto : IMapFrom<ProductPerformer>
    {
        public int PerformerId { get; set; }
        public string PerformerName { get; set; }
        public int ProductId { get; set; }   
        public string ProductName { get; set; }
        public string ProviderName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ProductPerformer, ProductPerformersDto>()
                .ForMember(p => p.ProviderName, m => m.MapFrom(src => src.Product.Provider.Name))
                .ForMember(p => p.PerformerName, m => m.MapFrom(src => src.Performer.FullName.ToString()));
        }

    }
}
