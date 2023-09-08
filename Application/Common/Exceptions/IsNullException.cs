using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingServices.Application.Common.Exceptions
{
    public class IsNullException : Exception
    {

        public IsNullException():base("Nie odnaleziono wskazanego zasobu.")
        {

        }

    }
}
