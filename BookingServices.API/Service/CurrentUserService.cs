using BookingServices.Application.Common.Interfaces;
using IdentityModel;
using System.Security.Claims;

namespace BookingServices.API.Service
{
    public class CurrentUserService : IcurrentUserService
    {
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
        public CurrentUserService (IHttpContextAccessor htppContextAccessor)
        {
            var email = htppContextAccessor.HttpContext?.User?.FindFirstValue(JwtClaimTypes.Email);
            Email = email;
            IsAuthenticated = !string.IsNullOrEmpty(email);
        }
    }
}
