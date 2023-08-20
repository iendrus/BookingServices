using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider;
using BookingServices.Application.ServiceProviders.Commands.UpdateServiceProvider;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviders;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{

    [Route("api/serviceProviders")]
    public class ServiceProvidersController : BaseController
    {
        /// <summary>
        /// Returns the Service Provider details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        
        public async Task<ActionResult<ServiceProviderDatailVm>> GetServiceProviderDetails(int id)
        {
            var vm = await Mediator.Send(new GetServiceProviderDatailQuery() { Id = id });
            return vm;
        }


        /// <summary>
        /// Returns a list of Service Providers by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="industryId"></param>
        /// <param name="city">Enter the beginning part of the search phrase. Capitalization does not matter.</param>
        /// <param name="name">Enter the beginning part of the search phrase. Capitalization does not matter.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ServiceProvidersVm>> GetServiceProividers(int? industryId, string? city, string? name)
        {
            var vm = await Mediator.Send(new GetServiceProvidersQuery() 
            { 
              IndustryId = industryId,
              City = city,
              Name = name
            });
            return vm;
        }

        /// <summary>
        /// Creates a new Service Provider
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateServiceProvider(CreateServiceProviderCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Deletes a Service Provider by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceProvider(int id)
        {
            var command = new DeleteServiceProviderCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }
        /// <summary>
        /// Updattes a Service Provider by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]


        public async Task<IActionResult> UpdateServiceProvider(int id, [FromBody] UpdateServiceProviderCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
