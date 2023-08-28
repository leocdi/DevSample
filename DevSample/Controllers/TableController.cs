using DevSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSample.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            var vm = Employee.SeedDemoList();
            return View(vm);
        }
    }
}
