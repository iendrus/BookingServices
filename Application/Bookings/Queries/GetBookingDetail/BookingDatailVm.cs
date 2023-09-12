using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.Bookings.Queries.GetBookingDetail
{
    public class BookingDatailVm : IMapFrom<Booking>
    {
        public int Id { get; set; }
        public string PerformerFullName { get; set; }
        public string RecipientFullName { get; set; }
        public string? RecipientPhoneNumber { get; set; }
        public string RecipientEmailAddress { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProviderName { get; set; }
        public DateTime StartOfService { get; set; }
        public DateTime EndOfService { get; set; }
        public Decimal Cost { get; set; }
        public BookingState State { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Booking, BookingDatailVm>()
                .ForMember(s => s.PerformerFullName, m => m.MapFrom(src => src.Offer.Performer.FullName.ToString()))
                .ForMember(s => s.ProviderName, m => m.MapFrom(src => src.Offer.Performer.Provider.Name))
                .ForMember(s => s.StartOfService, m => m.MapFrom(src => src.Offer.StartOfService))
                .ForMember(s => s.EndOfService, m => m.MapFrom(src => src.Offer.EndOfService))
                .ForMember(s => s.ProductName, m => m.MapFrom(src => src.Offer.Product.Name))
                .ForMember(s => s.ProductDescription, m => m.MapFrom(src => src.Offer.Product.Description))
                .ForMember(s => s.RecipientFullName, m => m.MapFrom(src => src.Recipient.FullName.ToString()))
                .ForMember(s => s.RecipientPhoneNumber, m => m.MapFrom(src => src.Recipient.Phone))
                .ForMember(s => s.RecipientEmailAddress, m => m.MapFrom(src => src.Recipient.Email.ToString()));
        }
    }
}

