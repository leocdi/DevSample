using DevSample.Data;
using DevSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevSample.Controllers
{
    public class MigrationController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnv;
        private readonly ApplicationDbContext _context;

        public MigrationController(ILogger<HomeController> logger, IWebHostEnvironment hostingEnv, ApplicationDbContext context)
        {
            _logger = logger;
            _hostingEnv = hostingEnv;
            _context = context;
        }

        public IActionResult Index()
        {
            var x = _context.GetInfrastructure().GetService<IMigrator>();
            var script = x.GenerateScript(null, null, MigrationsSqlGenerationOptions.Idempotent);
            List<string> applyedMigrations = _context.Database.GetAppliedMigrations().ToList();
            List<string> migrations = _context.Database.GetMigrations().ToList();
            MigrationViewModel vm = new()
            {
                Migrations= migrations,
                PendingMigrations= applyedMigrations,
                Script = script
            };
            return View(vm);
        }
    }
}
