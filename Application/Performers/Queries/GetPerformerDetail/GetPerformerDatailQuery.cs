using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Performers.Queries.GetPerformerDetail
{
    public class GetPerformerDatailQuery : IRequest<PerformerDatailVm>
    {
        public int Id { get; set; }
    }
}
