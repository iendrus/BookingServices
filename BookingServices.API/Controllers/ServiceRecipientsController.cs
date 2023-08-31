using BookingServices.Application.ServiceProviders.Commands.DeleteServiceProvider;
using BookingServices.Application.ServiceRecipients.Commands.CreateServiceRecipient;
using BookingServices.Application.ServiceRecipients.Commands.DeleteServiceRecipient;
using BookingServices.Application.ServiceRecipients.Commands.UpdateServiceRecipient;
using BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipientDetail;
using BookingServices.Application.ServiceRecipients.Queries.GetServiceRecipients;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/serviceRecipients")]
    [ApiController]

    public class ServiceRecipientsController : BaseController
    {
        /// <summary>
        /// Returns the Service Recipient details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]

        public async Task<ActionResult<ServiceRecipientDatailVm>> GetServiceRecipientDetails(int id)
        {
            var vm = await Mediator.Send(new GetServiceRecipientDatailQuery() { Id = id });
            return vm;
        }

        /// <summary>
        /// Creates a new Service Recipient
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> CreateServiceRecipient(CreateServiceRecipientCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }



        /// <summary>
        /// Returns a list of Service Recipients by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="id"></param>
        /// <param name="emailAddress"></param>
        /// <returns></returns>

        [HttpGet]
        public async Task<ActionResult<ServiceRecipientsVm>> GetServiceRecipients(int? id, string? emailAddress)
        {
            var vm = await Mediator.Send(new GetServiceRecipientsQuery()
            {
                Id = id,
                EmailAddress = emailAddress
            }) ;
            return vm;
        }

        /// <summary>
        /// Updattes a Service Recipient by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServiceRecipient(int id, [FromBody] UpdateServiceRecipientCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            var result = await Mediator.Send(command);

            return Ok(result);
        }

        /// <summary>
        /// Deletes a Service Recipient by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceRecipient(int id)
        {
            var command = new DeleteServiceRecipientCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }

    }
}
