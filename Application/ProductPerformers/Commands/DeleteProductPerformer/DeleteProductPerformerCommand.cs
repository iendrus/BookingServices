using MediatR;

namespace BookingServices.Application.ProductPerformers.Commands.DeleteProductPerformer
{
    public class DeleteProductPerformerCommand : IRequest
    {
        public int ProductId;
        public int PerformerId;
    }
}
