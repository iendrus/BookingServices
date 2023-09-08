using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.Offers.Queries.GetOfferDetail
{
    public class OfferDatailVm : IMapFrom<Offer>
    {
        public string PersonPerformerFullName { get; set; }
        public string ProductName { get; set; }
        public DateTime StartOfService { get; set; }
        public DateTime EndOfService { get; set; }
        public bool IsFinished { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Offer, OfferDatailVm>()
                .ForMember(s => s.PersonPerformerFullName, m => m.MapFrom(src => src.Performer.FullName.ToString()));
         }
    }
}

