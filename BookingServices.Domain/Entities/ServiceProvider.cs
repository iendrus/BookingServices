using BookingServices.Domain.Common;
using BookingServices.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Domain.Entities
{
    public class ServiceProvider : AuditableEntity
    {
        public string Name { get; set; }
        public PersonName ContactPerson { get; set; }
        public Email Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public int IndustryId { get; set; }

        public List<PersonPerforming> PersonPerformings { get; private set; } = new List<PersonPerforming>();
        public List<Service> Services { get; private set; } = new List<Service>();
    }
}
