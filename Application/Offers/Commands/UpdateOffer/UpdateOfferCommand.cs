using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Application.Offers.Commands.CreateOffer;
using BookingServices.Domain.Entities;
using MediatR;

namespace BookingServices.Application.Offers.Commands.UpdateOffer
{
    public class UpdateOfferCommand : IRequest, IMapFrom<UpdateOfferCommand>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Phone { get; set; }
        public int ProviderId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateOfferCommand, Offer>();
        }

    }
}
