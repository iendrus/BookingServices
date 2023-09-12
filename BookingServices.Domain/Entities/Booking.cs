using BookingServices.Domain.Common;
using System.Runtime.Serialization;

namespace BookingServices.Domain.Entities
{
    public class Booking : AuditableEntity
    {
        public int OfferId { get; set; }
        public int RecipientId { get; set; }
        public BookingState State { get; set;}
        public decimal Cost { get; set; }
        public Offer Offer { get; set; }
        public Recipient Recipient { get; set; }

    }


    public enum BookingState
    {
        [EnumMember(Value = "0")]
        Submitted = 0,

        [EnumMember(Value = "1")]
        Confirmed = 1,

        [EnumMember(Value = "2")]
        Rejected = 2,

        [EnumMember(Value = "3")]
        Finished = 3
    }
}
