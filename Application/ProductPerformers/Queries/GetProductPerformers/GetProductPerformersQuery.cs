using MediatR;


namespace BookingServices.Application.ProductPerformers.Queries.GetProductPerformers
{
    public class GetProductPerformersQuery : IRequest<ProductPerformersVm>
    {
        public int? ProductId { get; set; }
        public int? PerformerId { get; set; }
        public int? ProviderId { get; set; }
        public string? PerformerName { get; set; }
        public string? ProductName { get; set; }
        public string? ProviderName { get; set; }
    }
}
