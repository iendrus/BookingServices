using AutoMapper;
using BookingServices.Application.Common.Mappings;
using BookingServices.Domain.Entities;
using MediatR;


namespace BookingServices.Application.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommand : IRequest<int>, IMapFrom<CreateBookingCommand>
    {
        public int RecipientId { get; set; }
        public int OfferId { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateBookingCommand, Booking>();
        }
    }
}
