using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider
{
    public class CreateServiceProviderCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string? Nip { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string EmailDomainName { get; set; }
        public string EmailUserName { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public int IndustryId { get; set; }
        
    }
}
