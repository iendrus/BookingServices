using BookingServices.Application.Offers.Commands.CreateOffer;
using BookingServices.Application.Offers.Commands.DeleteOffer;
using BookingServices.Application.Offers.Commands.UpdateOffer;
using BookingServices.Application.Offers.Queries.GetOfferDetail;
using BookingServices.Application.Offers.Queries.GetOffers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/offers")]
    [ApiController]

    public class OffersController : BaseController
    {
        /// <summary>
        /// Returns the Service Performance details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<OfferDatailVm>> GetOfferDetails(int id)
        {
            var vm = await Mediator.Send(new GetOfferDatailQuery() { Id = id });
            return vm;
        }


        /// <summary>
        /// Returns the Service Performances list by Person Performer
        /// </summary>
        /// <param name="personPerformerId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<OffersByPersonPerformerVm>> GetOffersByPersonPerformer(int personPerformerId, bool? isFinished)
        {
            var vm = await Mediator.Send(new GetOffersByPersonPerformerQuery()
            {
                PersonPerformerId = personPerformerId,
                IsFinished = isFinished
            });
            return vm;
        }

        /// <summary>
        /// Creates a new Service Product
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateOffer(CreateOfferCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Updattes a Service Product by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOffer(int id, [FromBody] UpdateOfferCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Deletes a Service Product by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffer(int id)
        {
            var command = new DeleteOfferCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }


    }
}
