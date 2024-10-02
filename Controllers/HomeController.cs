using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly MouseService mouseService;

        public HomeController(MouseService mouseService)
        {
            this.mouseService = mouseService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveMouseData(List<MouseCoordinates> mouseData)
        {
            await this.mouseService.SaveMouseDataAsync(mouseData);
            return Ok();
        }
    }
}
