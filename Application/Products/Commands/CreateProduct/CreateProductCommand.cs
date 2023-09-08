using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>, IMapFrom<CreateProductCommand>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProviderId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductCommand, Product>();
        }

    }
}
