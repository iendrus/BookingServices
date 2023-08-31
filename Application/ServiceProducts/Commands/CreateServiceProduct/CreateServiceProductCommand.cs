using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ServiceProducts.Commands.CreateServiceProduct
{
    public class CreateServiceProductCommand : IRequest<int>, IMapFrom<CreateServiceProductCommand>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ServiceProviderId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateServiceProductCommand, ServiceProduct>();
        }

    }
}
