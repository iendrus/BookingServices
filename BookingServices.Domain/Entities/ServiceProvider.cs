using BookingServices.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Domain.Entities
{
    public class ServiceProvider : AuditableEntity
    {
        string Name { get; set; }
        string ContactPerson { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Description { get; set; }
        int IndustryId { get; set; }

        public List<PersonPerforming> PersonPerformings { get; private set; } = new List<PersonPerforming>();
        public List<Service> Services { get; private set; } = new List<Service>();
    }
}
