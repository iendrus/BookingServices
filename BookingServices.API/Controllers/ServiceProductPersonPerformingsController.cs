using BookingServices.Application.ServiceProductPersonPerformings.Commands.CreateServiceProductPersonPerforming;
using BookingServices.Application.ServiceProductPersonPerformings.Commands.DeleteServiceProductPersonPerforming;
using BookingServices.Application.ServiceProductPersonPerformings.Queries.GetServiceProductPersonPerformings;
using BookingServices.Application.ServiceProducts.Commands.DeleteServiceProduct;
using BookingServices.Application.ServiceProducts.Queries.GetServiceProducts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/serviceProductPersonPerformings")]
    [ApiController]
    public class ServiceProductPersonPerformingsController : BaseController
    {

        /// <summary>
        /// Returns a list of ServiceProduct for PersonPerforming, by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="serviceProductName">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <param name="personPerformingName">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ServiceProductPersonPerformingsVm>> ServiceProductPersonPerformings(string? personPerformingName, string? serviceProductName)
        {
            var vm = await Mediator.Send(new GetServiceProductPersonPerformingsQuery()
            {
                ServiceProductName = serviceProductName,
                PersonPerformingName = personPerformingName
                
            });
            return vm;
        }


        /// <summary>
        /// Creates a new ServiceProduct for PersonPerforming
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateServiceProductPersonPerforming(CreateServiceProductPersonPerformingCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Deletes a ServiceProduct for PersonPerforming by ServiceProductId and PersonPerformingId
        /// </summary>
        /// <param name="personPerformingId"></param>
        /// <param name="serviceProductId"></param>
        /// <returns></returns>
        [HttpDelete("{personPerformingId},{serviceProductId}")]
        public async Task<IActionResult> DeleteServiceProductPersonPerforming(int personPerformingId, int serviceProductId)
        {
            var command = new DeleteServiceProductPersonPerformingCommand
            {
                ServiceProductId = serviceProductId,
                PersonPerformingId = personPerformingId
            };
            await Mediator.Send(command);
            return NoContent();
        }


    }
}
