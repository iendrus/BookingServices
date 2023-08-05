using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;

namespace BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider
{
    public class CreateServiceProviderCommand : IRequest<int>, IMapFrom<CreateServiceProviderCommand>
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
            profile.CreateMap<CreateServiceProviderCommand, ServiceProvider>()
                  .ForMember(s => s.Email, m => m.MapFrom(src => Email.For(src.EmailAddress)))
                  .ForPath(s => s.ContactPerson.FirstName, m => m.MapFrom(src => src.ContactFirstName))
                  .ForPath(s => s.ContactPerson.LastName, m => m.MapFrom(src => src.ContactLastName))
                  .ForPath(s => s.Address.Street, m => m.MapFrom(src => src.Street))
                  .ForPath(s => s.Address.City, m => m.MapFrom(src => src.City))
                  .ForPath(s => s.Address.ZipCode, m => m.MapFrom(src => src.ZipCode))
                  .ForPath(s => s.Address.Number, m => m.MapFrom(src => src.Number));
        }
    }
}
