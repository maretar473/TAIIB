using Microsoft.AspNetCore.Mvc;
using BLL;
using BLL.DTO;

namespace MT_TAIIB_WebApi.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
