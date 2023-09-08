using MediatR;


namespace BookingServices.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public int Id;
    }
}
