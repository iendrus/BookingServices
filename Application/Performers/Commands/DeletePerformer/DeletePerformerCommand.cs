using MediatR;


namespace BookingServices.Application.Performers.Commands.DeletePerformer
{
    public class DeletePerformerCommand : IRequest
    {
        public int Id { get; set; }

    }
}
