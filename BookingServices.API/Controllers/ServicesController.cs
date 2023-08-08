using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/v1/services")]
    public class ServicesController : ControllerBase
    {
        /// <summary>
        /// Returns a list of all services
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetServices()
        {
            return Ok();
        }

        /// <summary>
        /// Returns the service by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetServiceById(int id)
        {
            return Ok();
        }


        /// <summary>
        /// Creates a new service
        /// </summary>
        /// <param name="obj"></param>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateService(object obj)
        {
            return Ok();
        }

        /// <summary>
        /// Modifies the service 
        /// </summary>
        /// <param name="id"></param>

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateService(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Removes the service
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteService(int id)
        {
            return Ok();
        }

    }
}
