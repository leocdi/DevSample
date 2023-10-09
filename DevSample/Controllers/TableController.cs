using DevSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevSample.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            var vm = Seeder.SeedDatatableSampleViewModel();
            return View(vm);
        }

        public IActionResult TableAvecAjax()
        {
            var vm = Seeder.SeedEmptyDatatableSampleViewModel();
            return View(vm);
        }

        public JsonResult LoadAjax()
        {
            return Json(Seeder.SeedDemoEmployeeList());
        }
    }
}
