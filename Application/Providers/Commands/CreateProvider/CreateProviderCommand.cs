using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Providers.Queries.GetProviderDetail;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;

namespace BookingServices.Application.Providers.Commands.CreateProvider
{
    public class CreateProviderCommand : IRequest<int>, IMapFrom<CreateProviderCommand>
    {
        public string Name { get; set; }
        public string? Nip { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public int IndustryId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateProviderCommand, Provider>()
                 .ForMember(s => s.Email, m => m.MapFrom(src => Email.For(src.EmailAddress)))
                 .ForMember(s => s.ContactPerson, m => m.MapFrom(src => new PersonName(src.ContactFirstName, src.ContactLastName)))
                 .ForMember(s => s.Address, m => m.MapFrom(src => new Address(src.Street, src.City, src.ZipCode, src.Number)));
        }
    }
}
