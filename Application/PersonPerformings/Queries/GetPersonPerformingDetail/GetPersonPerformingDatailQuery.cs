using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.PersonPerformings.Queries.GetPersonPerformingDetail
{
    public class GetPersonPerformingDatailQuery : IRequest<PersonPerformingDatailVm>
    {
        public int Id { get; set; }
    }
}
