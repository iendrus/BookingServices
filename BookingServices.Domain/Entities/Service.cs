using BookingServices.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Domain.Entities
{
    public class Service : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ServicePorviderId { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public ICollection<PersonPerforming>  PersonPerformings { get; set; }
    }
}
