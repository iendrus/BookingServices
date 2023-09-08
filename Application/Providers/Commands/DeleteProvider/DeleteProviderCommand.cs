using MediatR;


namespace BookingServices.Application.Providers.Commands.DeleteProvider
{
    public class DeleteProviderCommand : IRequest
    {
        public int Id { get; set; }

    }
}
