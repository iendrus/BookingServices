

namespace BookingServices.Application.Common.Exceptions
{
    public class TimeRangeUnavalaibleException : Exception
    {
        public TimeRangeUnavalaibleException():base("Wskazany zakres czasowy u tego Wykonawcy jest niedostępny.")
        {

        }
    }
}
