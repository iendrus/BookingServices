using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider;
using BookingServices.Application.ServiceProviders.Commands.UpdateServiceProvider;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviders;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/serviceProviders")]
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
        /// Returns a list of Service Providers by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="industryId"></param>
        /// <param name="city">Returns items that match the entered phrase or where the first part matches the entered phrase. Capitalization does not matter.</param>
        /// <param name="name">Returns items that match the entered phrase or where the first part matches the entered phrase. Capitalization does not matter.</param>
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
            var command = new DeleteServiceProviderCommand { ServiceProviderId = id };
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
        public async Task<IActionResult> UpdateServiceProvider(UpdateServiceProviderCommand command, int id)
        {
            command.SetId(id);
            var result = await Mediator.Send(command);
            return Ok(result);
        }

    }
}
