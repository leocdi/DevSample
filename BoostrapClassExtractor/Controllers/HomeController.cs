using BoostrapClassExtractor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BoostrapClassExtractor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostStyles([FromBody] List<string?> classes)
        {
           

            var filtered = classes.Where(x => x != null && x.StartsWith(".") && !x.Contains(" ") && !x.Contains("=") && !x.Contains("[") && x.Count(x => x == '.') < 2 && !x.Contains(":")).ToList();
            var tupple = filtered.Select(x => new { constName = x.Replace('-','_').Replace(".", string.Empty), className = x.Replace(".", string.Empty) });
            var x = AppDomain.CurrentDomain.BaseDirectory;
            // create a file at pathName
            using FileStream fs = System.IO.File.Create($"C:\\Users\\leopard\\source\\repos\\DevSample\\BoostrapClassExtractor\\Generated\\BsConstants.cs");
            using StreamWriter sw = new(fs);
            sw.WriteLine("public static class Bs5");
            sw.WriteLine("{");
            foreach (var c in tupple)
            {
                sw.WriteLine($"    public const string {c.constName} = \"{c.className}\";");
            }
            sw.WriteLine("}");

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