using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Recipients.Queries.GetRecipientDetail;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;
using System.Reflection.Metadata;

namespace BookingServices.Application.Recipients.Commands.CreateRecipient
{
    public class CreateRecipientCommand : IRequest<int>, IMapFrom<CreateRecipientCommand>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Phone { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateRecipientCommand, Recipient>()
                 .ForMember(s => s.FullName, m => m.MapFrom(src => new PersonName(src.FirstName, src.LastName)))
                 .ForMember(s => s.Email, m => m.MapFrom(src => Email.For(src.EmailAddress)));
        }
    }
}
