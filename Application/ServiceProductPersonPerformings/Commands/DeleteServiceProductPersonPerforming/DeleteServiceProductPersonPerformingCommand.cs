using MediatR;


namespace BookingServices.Application.ServiceProductPersonPerformings.Commands.DeleteServiceProductPersonPerforming
{
    public class DeleteServiceProductPersonPerformingCommand : IRequest
    {
        public int ServiceProductId;
        public int PersonPerformingId;

    }
}
