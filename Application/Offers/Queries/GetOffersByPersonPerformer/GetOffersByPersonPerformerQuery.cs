using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Offers.Queries.GetOffers
{
    public class GetOffersByPersonPerformerQuery : IRequest<OffersByPersonPerformerVm>
    {
        public int PersonPerformerId { get; set; }
        public bool? IsFinished { get; set; }

    }
}
