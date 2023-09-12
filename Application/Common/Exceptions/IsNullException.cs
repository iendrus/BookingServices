

using System.Runtime.InteropServices;

namespace BookingServices.Application.Common.Exceptions
{
    public class IsNullException : Exception
    {

        public IsNullException(string message = "Nie odnaleziono wskazanego zasobu.") :base(message)
        {

        }

    }
}
