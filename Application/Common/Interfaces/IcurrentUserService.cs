namespace BookingServices.Application.Common.Interfaces
{
    public interface IcurrentUserService
    {
        string Email { get; set; }
        bool IsAuthenticated { get; set; }
    }
}
