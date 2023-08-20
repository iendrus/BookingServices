using MediatR;


namespace BookingServices.Application.ServiceRecipients.Commands.DeleteServiceRecipient
{
    public class DeleteServiceRecipientCommand : IRequest
    {
        public int Id { get; set; }

    }
}
