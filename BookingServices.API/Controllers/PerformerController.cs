using BookingServices.Application.Performers.Commands.CreatePerformer;
using BookingServices.Application.Performers.Commands.DeletePerformer;
using BookingServices.Application.Performers.Commands.UpdatePerformer;
using BookingServices.Application.Performers.Queries.GetPerformerDetail;
using BookingServices.Application.Performers.Queries.GetPerformers;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/performers")]
    [ApiController]
    public class PerformerController : BaseController
    {


        /// <summary>
        /// Returns the Person Performing details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
  
        [HttpGet("{id}")]

        public async Task<ActionResult<PerformerDatailVm>> GetPerformerDetails(int id)
        {
            var vm = await Mediator.Send(new GetPerformerDatailQuery() { Id = id });
            return vm;
        }

        /// <summary>
        /// Creates a new Person Performing
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
  
        [HttpPost]
        public async Task<IActionResult> CreatePerformer(CreatePerformerCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }



        /// <summary>
        /// Returns a list of Person Performings by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="fullName"></param>
        /// <returns></returns>

        [HttpGet]
        public async Task<ActionResult<PerformersVm>> GetPerformers(int? providerId, string? fullName)
        {
            var vm = await Mediator.Send(new GetPerformersQuery()
            {
                ProviderId = providerId,
                FullName = fullName
            });
            return vm;
        }

        /// <summary>
        /// Updates a Person Performing by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
   
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePerformer(int id, [FromBody] UpdatePerformerCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            await Mediator.Send(command);
            return NoContent();
        }
        
        /// <summary>
        /// Deletes a Person Performing by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerformer(int id)
        {
            var command = new DeletePerformerCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
