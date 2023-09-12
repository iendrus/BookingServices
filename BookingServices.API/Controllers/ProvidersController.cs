using BookingServices.Application.Providers.Commands.CreateProvider;
using BookingServices.Application.Providers.Commands.DeleteProvider;
using BookingServices.Application.Providers.Commands.UpdateProvider;
using BookingServices.Application.Providers.Queries.GetProviderDetail;
using BookingServices.Application.Providers.Queries.GetProviders;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{

    [Route("api/providers")]
    public class ProvidersController : BaseController
    {
        /// <summary>
        /// Returns the Service Provider details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        
        public async Task<ActionResult<ProviderDatailVm>> GetProviderDetails(int id)
        {
            var vm = await Mediator.Send(new GetProviderDatailQuery() { Id = id });
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
        public async Task<ActionResult<ProvidersVm>> GetServiceProividers(int? industryId, string? city, string? name)
        {
            var vm = await Mediator.Send(new GetProvidersQuery() 
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
        public async Task<IActionResult> CreateProvider(CreateProviderCommand command)
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
        public async Task<IActionResult> DeleteProvider(int id)
        {
            var command = new DeleteProviderCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }
        /// <summary>
        /// Updates a Service Provider by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateProvider(int id, [FromBody] UpdateProviderCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
