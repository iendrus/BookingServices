using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Domain.Common
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? ModifiedBy { get; set;}
        public DateTime? ModifiedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
