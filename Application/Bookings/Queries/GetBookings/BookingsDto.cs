using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;


namespace BookingServices.Application.Bookings.Queries.GetBookings
{
    public class BookingsDto : IMapFrom<Booking>
    {
        public int Id { get; set; }
        public int PerformerId { get; set; }
        public int ProviderId { get; set; }
        public int ProductId { get; set; }
        public int RecipientId { get; set; }
        public string PerformerFullName { get; set; }
        public string ProviderName { get; set; }
        public string ProductName { get; set; }
        public string RecipientFullName { get; set; }
        public DateTime StartOfService { get; set; }
        public DateTime EndOfService { get; set; }
        public BookingState State { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<Booking, BookingsDto>()
                .ForMember(s => s.PerformerId, m => m.MapFrom(src => src.Offer.PerformerId))
                .ForMember(s => s.ProviderId, m => m.MapFrom(src => src.Offer.Performer.Provider.Id))
                .ForMember(s => s.ProductId, m => m.MapFrom(src => src.Offer.ProductId))
                .ForMember(s => s.PerformerFullName, m => m.MapFrom(src => src.Offer.Performer.FullName.ToString()))
                .ForMember(s => s.ProviderName, m => m.MapFrom(src => src.Offer.Performer.Provider.Name))
                .ForMember(s => s.StartOfService, m => m.MapFrom(src => src.Offer.StartOfService))
                .ForMember(s => s.EndOfService, m => m.MapFrom(src => src.Offer.EndOfService))
                .ForMember(s => s.ProductName, m => m.MapFrom(src => src.Offer.Product.Name))
                .ForMember(s => s.RecipientFullName, m => m.MapFrom(src => src.Recipient.FullName.ToString()));
        }
    }
}
