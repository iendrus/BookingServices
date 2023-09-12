using BookingServices.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingServices.Domain.Entities
{
    public class ProductPerformer
    {
        public Product? Product { get; set; }
        public Performer? Performer { get; set; }
        public int ProductId { get; set; }
        public int PerformerId { get; set; }
    }
}
