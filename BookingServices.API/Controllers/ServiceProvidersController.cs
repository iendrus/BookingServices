using BookingServices.Application.ServiceProviders.Commands.CreateServiceProvider;
using BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/serviceProviders")]
    public class ServiceProvidersController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceProviderDatailVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetServiceProviderDatailQuery() { ServiceProviderId= id });
            return vm;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceProvidersVm>> GetServiceProividers()
        {
            var vm = await Mediator.Send(new GetServiceProvidersQuery() );
            return vm;
        }

        [HttpPost]
        public async Task<IActionResult> CreateServiceProvider(CreateServiceProviderCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceProvider(int id)
        {
            var command = new DeleteServiceProviderCommand { ServiceProviderId = id };
            await Mediator.Send(command);
            return NoContent();
        }

    }
}
