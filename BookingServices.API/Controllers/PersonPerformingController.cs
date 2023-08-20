using BookingServices.Application.PersonPerformings.Commands.CreatePersonPerforming;
using BookingServices.Application.PersonPerformings.Commands.UpdatePersonPerforming;
using BookingServices.Application.PersonPerformings.Queries.GetPersonPerformingDetail;
using BookingServices.Application.PersonPerformings.Queries.GetPersonPerformings;
using BookingServices.Application.ServiceProviders.Commands.UpdateServiceProvider;
using BookingServices.Application.ServiceProviders.Queries.GetServiceProviderDetail;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/personPerformings")]
    [ApiController]
    public class PersonPerformingController : BaseController
    {


        /// <summary>
        /// Returns the Person Performing details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
  
        [HttpGet("{id}")]

        public async Task<ActionResult<PersonPerformingDatailVm>> GetPersonPerformingDetails(int id)
        {
            var vm = await Mediator.Send(new GetPersonPerformingDatailQuery() { Id = id });
            return vm;
        }

        /// <summary>
        /// Creates a new Person Performing
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
  
        [HttpPost]
        public async Task<IActionResult> CreatePersonPerforming(CreatePersonPerformingCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }



        /// <summary>
        /// Returns a list of Person Performings by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="serviceProviderId"></param>
        /// <param name="fullName"></param>
        /// <returns></returns>

        [HttpGet]
        public async Task<ActionResult<PersonPerformingsVm>> GetPersonPerformings(int? serviceProviderId, string? fullName)
        {
            var vm = await Mediator.Send(new GetPersonPerformingsQuery()
            {
                ServiceProviderId = serviceProviderId,
                FullName = fullName
            });
            return vm;
        }

        /// <summary>
        /// Updattes a Person Performing by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
   
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersonPerforming(int id, [FromBody] UpdatePersonPerformingCommand command)
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
