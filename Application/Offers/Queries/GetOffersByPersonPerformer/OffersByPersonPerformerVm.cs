using System;

namespace BookingServices.Application.Offers.Queries.GetOffers
{
    public class OffersByPersonPerformerVm
    {
        public ICollection<OffersByPersonPerformerDto> Offers { get; set; }
    }
}
