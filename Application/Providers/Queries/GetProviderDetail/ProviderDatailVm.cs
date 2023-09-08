using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using System;



namespace BookingServices.Application.Providers.Queries.GetProviderDetail
{
    public class ProviderDatailVm : IMapFrom<Provider>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string IndustryName { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Provider, ProviderDatailVm>()
                .ForMember(s => s.Email, m => m.MapFrom(src => src.Email.ToString()))
                .ForMember(s => s.Address, m => m.MapFrom(src => src.Address.ToString()))
                .ForMember(s => s.ContactPerson, m => m.MapFrom(src => src.ContactPerson.ToString()));
         }
    }
}
