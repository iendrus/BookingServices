using MediatR;


namespace BookingServices.Application.Offers.Commands.DeleteOffer
{
    public class DeleteOfferCommand : IRequest
    {
        public int Id { get; set; }

    }
}
