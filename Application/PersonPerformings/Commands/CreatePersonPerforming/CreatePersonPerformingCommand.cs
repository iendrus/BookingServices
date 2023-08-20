using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.PersonPerformings.Queries.GetPersonPerformingDetail;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;
using System.Reflection.Metadata;

namespace BookingServices.Application.PersonPerformings.Commands.CreatePersonPerforming
{
    public class CreatePersonPerformingCommand : IRequest<int>, IMapFrom<CreatePersonPerformingCommand>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Phone { get; set; }
        public int ServiceProviderId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreatePersonPerformingCommand, PersonPerforming>()
                 .ForMember(s => s.FullName, m => m.MapFrom(src => new PersonName(src.FirstName, src.LastName)))
                 .ForMember(s => s.Email, m => m.MapFrom(src => Email.For(src.EmailAddress)));
        }
    }
}
