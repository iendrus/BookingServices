using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Common.Exceptions
{ 
    public class NotExistsProductPerformerException : Exception
    {
        public NotExistsProductPerformerException() : base("Wskazany Dostawca lub Wykonawca nie ma aktywnej usługi, jak w żądaniu.")
        {

        }
    }
}
