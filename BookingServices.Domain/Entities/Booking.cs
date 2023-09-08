using BookingServices.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Domain.Entities
{
    public class Booking : AuditableEntity
    {
        public int OfferId { get; set; }
        public int PerformerId { get; set; }
        public int ProductId { get; set; }
        public int RecipientId { get; set; }
        public int State { get; set;}
        public decimal Cost { get; set; }
        public DateTime StartOfService { get; set; }
        public DateTime EndOfService { get; set; }
        public Offer Offer { get; set; }
        public Product Product { get; set; }
        public Performer Performer { get; set; }
        public Recipient Recipient { get; set; }

    }
}
