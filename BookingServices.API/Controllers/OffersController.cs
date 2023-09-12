using BookingServices.Application.Offers.Commands.CreateOffer;
using BookingServices.Application.Offers.Commands.DeleteOffer;
using BookingServices.Application.Offers.Commands.UpdateOffer;
using BookingServices.Application.Offers.Queries.GetOfferDetail;
using BookingServices.Application.Offers.Queries.GetOffers;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/offers")]
    [ApiController]

    public class OffersController : BaseController
    {
        /// <summary>
        /// Returns the Offer details by Id
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
        /// Returns the Offers list
        /// </summary>
        /// <param name="performerId"></param>
        /// <param name="providerId"></param>
        /// <param name="providerName"></param>
        /// <param name="isAvailable"></param>
        /// <param name="productName"></param>
        /// <param name="startOfServiceFrom"></param>
        /// <param name="startOfServiceTo"></param>
        /// <param name="isAnyServiceAvailableFrom"></param>
        /// <param name="isAnyServiceAvailableTo"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<OffersVm>> GetOffers(int? performerId, int? providerId, 
            string? providerName, bool? isAvailable, string? productName, DateTime? startOfServiceFrom, 
            DateTime? startOfServiceTo, DateTime? isAnyServiceAvailableFrom, DateTime? isAnyServiceAvailableTo)
        {
            var vm = await Mediator.Send(new GetOffersQuery()
            {
                PerformerId = performerId,
                IsAvailable = isAvailable,
                ProviderId = providerId,
                ProviderName = providerName,
                ProductName = productName,
                StartOfServiceFrom = startOfServiceFrom,
                StartOfServiceTo = startOfServiceTo,
                IsAnyServiceAvailableFrom = isAnyServiceAvailableFrom,
                IsAnyServiceAvailableTo = isAnyServiceAvailableTo
            });
            return vm;
        }

        /// <summary>
        /// Creates a new Offer
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
        /// Updates a Offer by Id
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
        /// Deletes a Offer by Id
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
