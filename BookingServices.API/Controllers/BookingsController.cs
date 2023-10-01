using AutoMapper;
using BookingServices.Application.Bookings.Commands.CreateBooking;
using BookingServices.Application.Bookings.Commands.DeleteBooking;
using BookingServices.Application.Bookings.Commands.UpdateBooking;
using BookingServices.Application.Bookings.Queries.GetBookingDetail;
using BookingServices.Application.Bookings.Queries.GetBookings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    //[Authorize]
    public class BookingsController : BaseController

   {
        private readonly IMapper _mapper;
        public BookingsController(IMapper mapper)
        {
            _mapper = mapper;
        }
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


        [HttpGet]
        public async Task<ActionResult<BookingsVm>> GetBookings([FromQuery] GetBookingsRequest request)
        {
            var query = new GetBookingsQuery();
            _mapper.Map(request, query);
            var vm = await Mediator.Send(query);
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
