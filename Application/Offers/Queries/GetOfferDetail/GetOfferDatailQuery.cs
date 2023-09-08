using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Offers.Queries.GetOfferDetail
{
    public class GetOfferDatailQuery : IRequest<OfferDatailVm>
    {
        public int Id { get; set; }
    }
}
