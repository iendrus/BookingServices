using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Performers.Queries.GetPerformerDetail;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;
using System.Reflection.Metadata;

namespace BookingServices.Application.Performers.Commands.CreatePerformer
{
    public class CreatePerformerCommand : IRequest<int>, IMapFrom<CreatePerformerCommand>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Phone { get; set; }
        public int ProviderId { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreatePerformerCommand, Performer>()
                 .ForMember(s => s.FullName, m => m.MapFrom(src => new PersonName(src.FirstName, src.LastName)))
                 .ForMember(s => s.Email, m => m.MapFrom(src => Email.For(src.EmailAddress)));
        }
    }
}
