using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;

namespace BookingServices.Application.Recipients.Commands.UpdateRecipient
{
    public class UpdateRecipientCommand : IRequest, IMapFrom<UpdateRecipientCommand>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Phone { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateRecipientCommand, Recipient>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => new PersonName(src.FirstName, src.LastName)))
                .ForMember(s => s.Email, m => m.MapFrom(src => Email.For(src.EmailAddress)))
                .IgnoreAuditableAndTypeOfClassMembers()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }

    }
}
