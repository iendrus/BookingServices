using BookingServices.Application.Products.Commands.CreateProduct;
using BookingServices.Application.Products.Commands.DeleteProduct;
using BookingServices.Application.Products.Commands.UpdateProduct;
using BookingServices.Application.Products.Queries.GetProductDetails;
using BookingServices.Application.Products.Queries.GetProducts;
using Microsoft.AspNetCore.Mvc;

namespace BookingServices.API.Controllers
{
    [Route("api/products")]
    [ApiController]

    public class ProductsController : BaseController
    {
        /// <summary>
        /// Returns the Service Product details by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetailVm>> GetProductDetails(int id)
        {
            var vm = await Mediator.Send(new GetProductDetailQuery() { Id = id });
            return vm;
        }

        /// <summary>
        /// Returns a list of Service Products by specified parameters or all if parameters are not defined
        /// </summary>
        /// <param name="name">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <param name="providerName">Enter any fragment of the search phrase. Capitalization does not matter.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ProductsVm>> GetProducts(string? name, string? providerName)
        {
            var vm = await Mediator.Send(new GetProductsQuery()
            {
                Name = name,
                ProviderName = providerName
            });
            return vm;
        }

        /// <summary>
        /// Creates a new Service Product
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Updates a Service Product by Id
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductCommand command)
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
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductCommand { Id = id };
            await Mediator.Send(command);
            return NoContent();
        }


    }
}
