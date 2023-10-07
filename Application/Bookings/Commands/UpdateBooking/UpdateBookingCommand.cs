using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;

namespace BookingServices.Application.Bookings.Commands.UpdateBooking
{
    public class UpdateBookingCommand : IRequest, IMapFrom<UpdateBookingCommand>
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public BookingState State { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateBookingCommand, Booking>()
                .ForMember(dest => dest.RecipientId, opt => opt.Ignore())
                .ForMember(dest => dest.OfferId, opt => opt.Ignore())
                .IgnoreAuditableAndTypeOfClassMembers()
                .IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
