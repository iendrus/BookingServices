using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using System;

namespace BookingServices.Application.PersonPerformings.Queries.GetPersonPerformings
{
    public class PersonPerformingsDto : IMapFrom<PersonPerforming>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ServiceProviderName { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<PersonPerforming, PersonPerformingsDto>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => src.FullName.ToString()));
        }
    }
}
