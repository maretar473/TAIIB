using Microsoft.AspNetCore.Mvc;
using BLL;
using BLL.DTO;

namespace MT_TAIIB_WebApi.Controllers
{
    /*[ApiController]
    [Route("api/controller")]*/
    public class ProductController : Controller
    {
        /*private readonly IProduct _productService;

        public ProductController(IProduct productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts([FromQuery] ProductFilterDTO filter)
        {
            try
            {
                var products = _productService.GetProducts(filter.Page, filter.PageSize, filter.NameFilter, filter.IsActiveFilter, filter.SortBy, filter.IsSortAscending);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductReqDTO productDTO)
        {
            try
            {
                var newProduct = _productService.AddProduct(productDTO);
                return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            try
            {
                var product = _productService.GetProduct(id);
                if (product == null)
                    return NotFound();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductReqDTO productDTO)
        {
            try
            {
                var updatedProduct = _productService.UpdateProduct(id, productDTO);
                return Ok(updatedProduct);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                _productService.DeleteProduct(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("{id}/activate")]
        public IActionResult ActivateProduct(int id)
        {
            try
            {
                _productService.ActivateProduct(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
*/

        public IActionResult Index()
        {
            return View();
        }
    }
}
