using BookingServices.Application.ServiceProducts.Commands.CreateServiceProduct;
using BookingServices.Application.ServiceProducts.Commands.DeleteServiceProduct;
using BookingServices.Application.ServiceProducts.Commands.UpdateServiceProduct;
using BookingServices.Application.ServiceProducts.Queries.GetServiceProductDetails;
using BookingServices.Application.ServiceProducts.Queries.GetServiceProducts;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/serviceProducts")]
    [ApiController]

    public class ServiceProductsController : BaseController
    {
        /// <summary>
        /// Returns the Service Product details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceProductDetailVm>> GetServiceProductDetails(int id)
        {
            var vm = await Mediator.Send(new GetServiceProductDetailQuery() { Id = id });
            return vm;
        }

        /// <summary>
        /// Returns a list of Service Products by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="name">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <param name="serviceProviderName">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ServiceProductsVm>> GetServiceProducts(string? name, string? serviceProviderName)
        {
            var vm = await Mediator.Send(new GetServiceProductsQuery()
            {
                Name = name,
                ServiceProviderName = serviceProviderName
            });
            return vm;
        }

        /// <summary>
        /// Creates a new Service Product
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateServiceProduct(CreateServiceProductCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Updattes a Service Product by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServiceProduct(int id, [FromBody] UpdateServiceProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Deletes a Service Product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceProduct(int id)
        {
            var command = new DeleteServiceProductCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }


    }
}
