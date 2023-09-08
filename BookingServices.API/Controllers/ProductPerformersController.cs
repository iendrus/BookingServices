using BookingServices.Application.ProductPerformers.Commands.CreateProductPerformer;
using BookingServices.Application.ProductPerformers.Commands.DeleteProductPerformer;
using BookingServices.Application.ProductPerformers.Queries.GetProductPerformers;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/productPerformers")]
    [ApiController]
    public class ProductPerformersController : BaseController
    {

        /// <summary>
        /// Returns a list of Product for Performer, by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="productName">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <param name="performerName">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <param name="providerName">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <param name="productId">Enter the search Id.</param>
        /// <param name="performerId">Enter the search Id.</param>
        /// <param name="providerId">Enter the search Id.</param>

        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ProductPerformersVm>> ProductPerformers(string? performerName, 
            string? productName, int? productId, int? performerId, string? providerName, int providerId)
        {
            var vm = await Mediator.Send(new GetProductPerformersQuery()
            {
                ProductName = productName,
                PerformerName = performerName,
                ProviderName = providerName,
                ProductId = productId,
                PerformerId= performerId,
                ProviderId = providerId
               
            });
            return vm;
        }


        /// <summary>
        /// Creates a new Product for Performer
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateProductPerformer(CreateProductPerformerCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Deletes a Product for Performer by ProductId and PerformerId
        /// </summary>
        /// <param name="performerId"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpDelete("{performerId},{productId}")]
        public async Task<IActionResult> DeleteProductPerformer(int performerId, int productId)
        {
            var command = new DeleteProductPerformerCommand
            {
                ProductId = productId,
                PerformerId = performerId
            };
            await Mediator.Send(command);
            return NoContent();
        }


    }
}
