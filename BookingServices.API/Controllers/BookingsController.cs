using BookingServices.Application.Bookings.Commands.CreateBooking;
using BookingServices.Application.Bookings.Commands.DeleteBooking;
using BookingServices.Application.Bookings.Commands.UpdateBooking;
using BookingServices.Application.Bookings.Queries.GetBookingDetail;
using BookingServices.Application.Bookings.Queries.GetBookings;
using BookingServices.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    public class BookingsController : BaseController
    {
        /// <summary>
        /// Returns the Booking details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDatailVm>> GetBookingDetails(int id)
        {
            var vm = await Mediator.Send(new GetBookingDatailQuery() { Id = id });
            return vm;
        }


        /// <summary>
        /// Returns the Bookings list
        /// </summary>
        /// <param name="performerId"></param>
        /// <param name="providerId"></param>
        /// <param name="productId"></param>
        /// <param name="recipientId"></param>
        /// <param name="recipientEmailAddress"></param>
        /// <param name="recipientPhoneNumber"></param>
        /// <param name="providerName"></param>
        /// <param name="productName"></param>
        /// <param name="state"></param>
        /// <param name="startOfServiceFrom"></param>
        /// <param name="startOfServiceTo"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<BookingsVm>> GetBookings(int? performerId, int? providerId,
            int? productId, int? recipientId, string? recipientEmailAddress, string? recipientPhoneNumber, 
            string? providerName, string? productName, BookingState state, DateTime? startOfServiceFrom,
            DateTime? startOfServiceTo)
        {
            var vm = await Mediator.Send(new GetBookingsQuery()
            {
                PerformerId = performerId,
                ProviderId = providerId,
                ProductId = productId,
                RecipientId = recipientId,
                RecipientEmailAddress = recipientEmailAddress,
                RecipientPhoneNumber = recipientPhoneNumber,
                ProviderName = providerName,
                ProductName = productName,
                State = state,
                StartOfServiceFrom = startOfServiceFrom,
                StartOfServiceTo = startOfServiceTo,
            });
            return vm;
        }

        /// <summary>
        /// Creates a new Booking
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Updates a Booking by Id. Fields available for updating: Cost, State
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBooking(int id, [FromBody] UpdateBookingCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("Id w parametrze i w komendzie muszą być zgodne.");
            }
            await Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Deletes a Booking by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var command = new DeleteBookingCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
