using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider
{
    public class DeleteServiceProviderCommand : IRequest
    {
        public int ServiceProviderId;
    }
}
