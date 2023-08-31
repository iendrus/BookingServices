using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.ServiceProducts.Commands.UpdateServiceProduct
{
    public class UpdateServiceProductCommand : IRequest<int>, IMapFrom<UpdateServiceProductCommand>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ServiceProviderID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateServiceProductCommand, ServiceProduct>();
        }
    }
}
