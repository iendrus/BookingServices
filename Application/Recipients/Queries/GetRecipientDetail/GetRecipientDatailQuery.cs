using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Recipients.Queries.GetRecipientDetail
{
    public class GetRecipientDatailQuery : IRequest<RecipientDatailVm>
    {
        public int Id { get; set; }
    }
}
