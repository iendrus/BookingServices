using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using BookingServices.Domain.ValueObjects;
using MediatR;


namespace BookingServices.Application.Offers.Commands.CreateOffer
{
    public class CreateOfferCommand : IRequest<int>, IMapFrom<CreateOfferCommand>
    {
        public int PerformerId { get; set; }
        public int ProductId { get; set; }
        public DateTime StartOfService { get; set; }
        public DateTime EndOfService { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateOfferCommand, Offer>();

        }
    }
}
