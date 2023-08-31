using MediatR;


namespace BookingServices.Application.ServiceProducts.Commands.DeleteServiceProduct
{
    public class DeleteServiceProductCommand : IRequest
    {
        public int Id;
    }
}
