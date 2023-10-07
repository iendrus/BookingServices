using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Industries.Queries.GetIndustryDetails;
using BookingServices.Domain.Entities;
using MediatR;



namespace BookingServices.Application.Industries.Commands.CreateIndustry
{
    public class CreateIndustryCommand : IRequest<int>, IMapFrom<CreateIndustryCommand>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateIndustryCommand, Industry>()
                .IgnoreAuditableAndTypeOfClassMembers()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
