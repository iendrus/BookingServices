using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.Offers.Queries.GetOfferDetail
{
    public class OfferDatailVm : IMapFrom<Offer>
    {
        public int Id { get; set; }
        public string PerformerFullName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProviderName { get; set; }
        public DateTime StartOfService { get; set; }
        public DateTime EndOfService { get; set; }
        public Decimal Cost { get; set; }
        public bool IsAvailable { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Offer, OfferDatailVm>()
                .ForMember(s => s.PerformerFullName, m => m.MapFrom(src => src.Performer.FullName.ToString()))
                .ForMember(s => s.ProviderName, m => m.MapFrom(src => src.Performer.Provider.Name));
        }
    }
}

