using System.Diagnostics;
using ActualServerTimeDisplay.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActualServerTimeDisplay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // This action will run when we go to the main page
        public IActionResult Index()
        {
            return View();
        }

        // This action will send the current server time as text
        [HttpGet]
        public IActionResult GetServerTime()
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            return Json(new { time = currentTime });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // This action will run when we go to the main page
        
    }
}
