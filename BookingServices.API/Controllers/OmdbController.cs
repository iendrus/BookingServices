using BookingServices.Application.Common.Interfaces;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using BookingServices.Infrastructure.ExternalAPI.OMDB;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/omdb")]
    [ApiController]
    public class OmdbController : ControllerBase
    {

        private readonly IOmdbClient _omdbClient;

        public OmdbController(IOmdbClient omdbClient)
        {
            _omdbClient = omdbClient;
        }

        [HttpGet("{searchFilter}")]
        public async Task<IActionResult> GetMovie(string searchFilter, CancellationToken cancellationToken)
        {
            try
            {
                var movieData = await _omdbClient.GetMovie(searchFilter, cancellationToken);
                return Ok(movieData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Something went wrong");
            }
        }
    }
}
