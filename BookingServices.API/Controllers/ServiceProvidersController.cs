using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviders;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{

    [Route("api/serviceProviders")]
    [EnableCors("MyAllowSpecificOrigins")]
    public class ServiceProvidersController : BaseController
    {
        /// <summary>
        /// Returns the Service Provider details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        
        public async Task<ActionResult<ServiceProviderDatailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetServiceProviderDatailQuery() { ServiceProviderId= id });
            return vm;
        }

        /// <summary>
        /// Returns a list of of Service Providers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ServiceProvidersVm>> GetServiceProividers()
        {
            var vm = await Mediator.Send(new GetServiceProvidersQuery() );
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
            var command = new DeleteServiceProviderCommand { ServiceProviderId = id };
            await Mediator.Send(command);
            return NoContent();
        }

    }
}
