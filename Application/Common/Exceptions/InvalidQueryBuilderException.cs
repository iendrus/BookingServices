using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Common.Exceptions
{
    public class InvalidQueryBuilderException : Exception
    { 
        public InvalidQueryBuilderException() : base("Nieprawidłowo skonstruowane zapytanie.")
        {

        }
    }
}
