using MediatR;


namespace BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider
{
    public class DeleteServiceProviderCommand : IRequest
    {
        public int Id { get; set; }

    }
}
