using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Providers.Queries.GetProviderDetail
{
    public class GetProviderDatailQuery : IRequest<ProviderDatailVm>
    {
        public int Id { get; set; }
    }
}
