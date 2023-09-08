using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;

namespace BookingServices.Application.Performers.Queries.GetPerformers
{
    public class PerformersDto : IMapFrom<Performer>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProviderName { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<Performer, PerformersDto>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => src.FullName.ToString()));
        }
    }
}
