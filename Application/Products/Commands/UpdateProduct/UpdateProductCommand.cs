using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest, IMapFrom<UpdateProductCommand>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProviderID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateProductCommand, Product>()
                .IgnoreAuditableAndTypeOfClassMembers()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
