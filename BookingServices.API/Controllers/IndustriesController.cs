using BookingServices.Application.Industries.Commands.CreateIndustry;
using BookingServices.Application.Industries.Commands.DeleteIndustry;
using BookingServices.Application.Industries.Commands.UpdateIndustry;
using BookingServices.Application.Industries.Queries.GetIndustries;
using BookingServices.Application.Industries.Queries.GetIndustryDetails;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/industries")]
    [ApiController]
    [Authorize(Roles = "Admin, Staff1, Staff2")]

    public class IndustriesController : BaseController
    {

        /// <summary>
        /// Returns the Industry details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IndustryDetailVm>> GetIndustryDetails(int id)
        {
            var vm = await Mediator.Send(new GetIndustryDetailQuery() { Id = id });
            return vm;
        }

        /// <summary>
        /// Returns a list of Industries by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="name">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <param name="description">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IndustriesVm>> GetIndustries(string? name, string? description)
        {
            var vm = await Mediator.Send(new GetIndustriesQuery()
            {
                Name = name,
                Description = description
            });
            return vm;
        }

        /// <summary>
        /// Creates a new Service Industry
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateIndustry(CreateIndustryCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Updates a Industry by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIndustry(int id, [FromBody] UpdateIndustryCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Deletes a Industry by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndustry(int id)
        {
            var command = new DeleteIndustryCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }

    }
}
