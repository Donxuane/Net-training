using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Service2 _service2;
        private readonly Service1 _service1;
        public HomeController(ILogger<HomeController> logger, Service2 service2, Service1 service1)
        {
            _logger = logger;
            _service2 = service2;
            _service1 = service1;
        }

        public ActionResult Minus(int number)
        {
            var time = DateTime.Now.AddMinutes(number);
            while (true)
            {
                if(DateTime.Now > time)
                {
                    break;
                }
            }
            var num1 = _service1.Substract(number);
            var num2 = _service2.Substract(number);

            return Ok(new { num1, num2});
        }

        public IActionResult Index()
        {
            return View();
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
