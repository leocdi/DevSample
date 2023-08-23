using DevSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;

namespace DevSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnv;


        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hostingEnv)
        {
            _logger = logger;
            _hostingEnv = hostingEnv;
        }

        public IActionResult Index()
        {
            AppInfoViewModel model = new()
            {
                Environment = _hostingEnv.EnvironmentName,
                FrameworkVersion = Environment.Version.ToString(),
                Culture = CultureInfo.CurrentCulture.Name,
                UiCulture = CultureInfo.CurrentUICulture.Name,
            };

            return View(model);
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