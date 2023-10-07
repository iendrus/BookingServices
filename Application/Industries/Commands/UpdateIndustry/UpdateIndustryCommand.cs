using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Industries.Commands.UpdateIndustry
{
    public class UpdateIndustryCommand : IRequest, IMapFrom<UpdateIndustryCommand>
    {
        public int Id { get; set; }
       public string Name { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateIndustryCommand, Industry>()
                 .IgnoreAuditableAndTypeOfClassMembers()
                 .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
