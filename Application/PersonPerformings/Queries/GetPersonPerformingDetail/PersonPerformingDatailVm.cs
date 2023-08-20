using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;



namespace BookingServices.Application.PersonPerformings.Queries.GetPersonPerformingDetail
{
    public class PersonPerformingDatailVm : IMapFrom<PersonPerforming>
    {
        public string FullName { get; set; }
        public string ServiceProviderName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PersonPerforming, PersonPerformingDatailVm>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => src.FullName.ToString()));
         }
    }
}
