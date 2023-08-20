using MediatR;


namespace BookingServices.Application.PersonPerformings.Commands.DeletePersonPerforming
{
    public class DeletePersonPerformingCommand : IRequest
    {
        public int Id { get; set; }

    }
}
