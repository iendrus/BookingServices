using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;



namespace BookingServices.Application.Performers.Queries.GetPerformerDetail
{
    public class PerformerDatailVm : IMapFrom<Performer>
    {
        public string FullName { get; set; }
        public string ProviderName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Performer, PerformerDatailVm>()
                .ForMember(s => s.FullName, m => m.MapFrom(src => src.FullName.ToString()));
         }
    }
}
