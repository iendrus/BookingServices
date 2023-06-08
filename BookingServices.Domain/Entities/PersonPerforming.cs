using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookingServices.Domain.Entities
{
    public class PersonPerforming : AuditableEntity
    {
        public PersonName FullName { get; set; }
        public Email Email { get; set; }
        public string Phone { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public int ServiceProviderId { get; set; }
        public ICollection<Service> Services{ get; set; }
        //public List<Service> Services { get; private set; } = new List<Service>();

    }
}
