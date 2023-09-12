using System;

namespace BookingServices.Application.Offers.Queries.GetOffers
{
    public class OffersVm
    {
        public ICollection<OffersDto> Offers { get; set; }
    }
}
