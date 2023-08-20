using System;

namespace BookingServices.Application.PersonPerformings.Queries.GetPersonPerformings
{
    public class PersonPerformingsVm
    {
        public ICollection<PersonPerformingsDto> PersonPerformings { get; set; }
    }
}
