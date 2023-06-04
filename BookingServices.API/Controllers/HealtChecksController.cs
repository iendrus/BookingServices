using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/hc")]
    [ApiController]
    public class HealtChecksController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [EnableCors("MyAllowSpecificOrigins")]
        //[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel)]

        public async Task<ActionResult<string>> GestAsync()
        {
            return "Healtly";
        }

    }
}
