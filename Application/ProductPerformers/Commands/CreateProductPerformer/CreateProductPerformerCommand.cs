using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ProductPerformers.Commands.CreateProductPerformer
{
    public class CreateProductPerformerCommand : IRequest<int>, IMapFrom<CreateProductPerformerCommand>
    {
        public int ProductId { get; set; }
        public int PerformerId{ get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProductPerformerCommand, ProductPerformer>()
                .IgnoreAuditableAndTypeOfClassMembers()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
