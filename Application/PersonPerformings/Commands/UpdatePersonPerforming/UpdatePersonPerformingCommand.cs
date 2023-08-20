using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;

namespace BookingServices.Application.PersonPerformings.Commands.UpdatePersonPerforming
{
    public class UpdatePersonPerformingCommand : IRequest<int>, IMapFrom<UpdatePersonPerformingCommand>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Phone { get; set; }
        public int ServiceProviderId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdatePersonPerformingCommand, PersonPerforming>()
                 .ForMember(s => s.FullName, m => m.MapFrom(src => new PersonName(src.FirstName, src.LastName)))
                 .ForMember(s => s.Email, m => m.MapFrom(src => Email.For(src.EmailAddress)));
        }

    }
}
