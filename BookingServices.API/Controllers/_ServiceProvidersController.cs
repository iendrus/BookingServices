//using BookingServices.API;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Mvc;



//namespace BookingServices.API.Controllers
//{
//    [Route("api/v1/service-providers")]
//    [ApiController]
//    [EnableCors("MyAllowSpecificOrigins")]
//    public class ServiceProvidersController : ControllerBase
//    {
//        /// <summary>
//        /// Returns a list of all Service Providers
//        /// </summary>
//        /// <returns></returns>
//        [HttpGet]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public async Task<IActionResult> GetServiceProviders()
//        {
//            return Ok();
//        }

//        /// <summary>
//        /// Returns the Service Provider by Id
//        /// </summary>
//        /// <param name="id"></param>
//        /// <returns></returns>
//        [HttpGet("{id}")]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]

//        public async Task<IActionResult> GetServiceProviderById(int id)
//        {
//            return Ok();
//        }


//        /// <summary>
//        /// Creates a new Service Provider
//        /// </summary>
//        /// <param name="obj"></param>
//        [HttpPost]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        public async Task<IActionResult> CreateServiceProvider(object obj)
//        {
//            return Ok();
//        }

//        /// <summary>
//        /// Modifies the Service Provider's data
//        /// </summary>
//        /// <param name="id"></param>

//        [HttpPut("{id}")]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status204NoContent)]
//        public async Task<IActionResult> UpdateServiceProvider(int id)
//        {
//            return Ok();
//        }

//        /// <summary>
//        /// Removes the Service Provider
//        /// </summary>
//        /// <param name="id"></param>
//        [HttpDelete("{id}")]
//        [ProducesResponseType(StatusCodes.Status202Accepted)]
//        [ProducesResponseType(StatusCodes.Status204NoContent)]
//        public async Task<IActionResult> DeleteServiceProvider(int id)
//        {
//            return Ok();
//        }
//    }
//}
