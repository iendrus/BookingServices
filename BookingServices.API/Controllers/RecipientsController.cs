using BookingServices.Application.Providers.Commands.DeleteProvider;
using BookingServices.Application.Recipients.Commands.CreateRecipient;
using BookingServices.Application.Recipients.Commands.DeleteRecipient;
using BookingServices.Application.Recipients.Commands.UpdateRecipient;
using BookingServices.Application.Recipients.Queries.GetRecipientDetail;
using BookingServices.Application.Recipients.Queries.GetRecipients;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/recipients")]
    [ApiController]

    public class RecipientsController : BaseController
    {
        /// <summary>
        /// Returns the Service Recipient details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]

        public async Task<ActionResult<RecipientDatailVm>> GetRecipientDetails(int id)
        {
            var vm = await Mediator.Send(new GetRecipientDatailQuery() { Id = id });
            return vm;
        }

        /// <summary>
        /// Creates a new Service Recipient
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> CreateRecipient(CreateRecipientCommand command)
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
        public async Task<ActionResult<RecipientsVm>> GetRecipients(int? id, string? emailAddress)
        {
            var vm = await Mediator.Send(new GetRecipientsQuery()
            {
                Id = id,
                EmailAddress = emailAddress
            }) ;
            return vm;
        }

        /// <summary>
        /// Updates a Service Recipient by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecipient(int id, [FromBody] UpdateRecipientCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Deletes a Service Recipient by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipient(int id)
        {
            var command = new DeleteRecipientCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }

    }
}
