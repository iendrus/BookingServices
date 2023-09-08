using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;

namespace BookingServices.Application.Providers.Queries.GetProviders
{
    public class ProvidersDto : IMapFrom<Provider>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IndustryName { get; set; }
        public string City { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<Provider, ProvidersDto>()
                .ForMember(s => s.City, m => m.MapFrom(src => src.Address.City));
        }
    }
}
