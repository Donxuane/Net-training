using AsyncProgram.Models;
using AsyncProgram.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace AsyncProgram.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        public async Task<IActionResult> Index()
        {
            var test = new AsyncM();
             var fdd = BuildString();
            var result = await test.TakeAction();
            return View();
        }

        public string BuildString()
        {
            var str = new StringBuilder();

            str.AppendLine("fdf");
            str.AppendLine("dds");
            return str.ToString();
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
