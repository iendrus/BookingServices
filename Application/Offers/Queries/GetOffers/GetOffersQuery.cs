using MediatR;


namespace BookingServices.Application.Offers.Queries.GetOffers
{
    public class GetOffersQuery : IRequest<OffersVm>
    {
        public int? PerformerId { get; set; }
        public int? ProviderId { get; set; }
        public string? ProviderName { get; set; }
        public string? ProductName { get; set; }
        public bool? IsAvailable { get; set; }
        public DateTime? StartOfServiceFrom { get; set; }
        public DateTime? StartOfServiceTo { get; set; }
        public DateTime? IsAnyServiceAvailableFrom { get; set; }
        public DateTime? IsAnyServiceAvailableTo { get; set; }
    }
}
