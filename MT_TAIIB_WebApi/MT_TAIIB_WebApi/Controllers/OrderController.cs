using Microsoft.AspNetCore.Mvc;
using BLL;
using BLL.DTO;

namespace MT_TAIIB_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrder _orderService;

        public OrderController(IOrder orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _orderService.GetAllOrders();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            try
            {
                var order = _orderService.GetOrderById(id);
                if (order == null)
                    return NotFound();

                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}/positions")]
        public IActionResult GetOrderPositions(int id)
        {
            try
            {
                var orderPositions = _orderService.GetOrderPositions(id);
                return Ok(orderPositions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("user/{userId}")]
        public IActionResult GetUserOrders(int userId)
        {
            try
            {
                var userOrders = _orderService.GetUserOrders(userId);
                return Ok(userOrders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
