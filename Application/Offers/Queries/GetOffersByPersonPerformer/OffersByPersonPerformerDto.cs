using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Offers.Queries.GetOfferDetail;
using BookingServices.Domain.Entities;
using System;

namespace BookingServices.Application.Offers.Queries.GetOffers
{
    public class OffersByPersonPerformerDto : IMapFrom<Offer>
    {
        public int Id { get; set; }
        public string RecipientFullName { get; set; }
        public string PersonPerformerFullName { get; set; }
        public string ProductName { get; set; }
        public DateTime StartOfService { get; set; }
        public DateTime EndOfService { get; set; }
        public bool IsFinished { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<Offer, OffersByPersonPerformerDto>()
                .ForMember(s => s.PersonPerformerFullName, m => m.MapFrom(src => src.Performer.FullName.ToString()));
        }
    }
}
