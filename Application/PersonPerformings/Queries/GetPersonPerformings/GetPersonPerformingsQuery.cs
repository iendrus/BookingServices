using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.PersonPerformings.Queries.GetPersonPerformings
{
    public class GetPersonPerformingsQuery : IRequest<PersonPerformingsVm>
    {
        public int? ServiceProviderId { get; set; }
        public string? FullName { get; set; }
    }
}
