using HttpRequests.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HttpRequests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get")]
        public async Task<ActionResult<string>> GetData()
        {
            var ob = new Service();
            return await ob.GetResponse();
        }
        [LoggingMiddleware]
        [HttpGet("test")]
        public IActionResult Indexooo()
        {
            string test = "dfdfd";

            var test1 = test.ExstetntionForString();
            return Ok(test1);
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
    }
}
