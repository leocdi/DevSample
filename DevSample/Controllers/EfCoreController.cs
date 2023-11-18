using DevSample.Data;
using DevSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using System.Data;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DevSample.Controllers
{
    public class EfCoreController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnv;
        private readonly ApplicationDbContext _context;

        public EfCoreController(ILogger<HomeController> logger, IWebHostEnvironment hostingEnv, ApplicationDbContext context)
        {
            _logger = logger;
            _hostingEnv = hostingEnv;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var query = _context.Todos;
            var todos = await query.ToListAsync();

            var dt = _context.DataTable("select *, 1 as uno, 2 as Tada from Todo");

            //var specialqueryable = _context.Database.SqlQueryRaw<string?>("select *, 1 as uno, 2 as Tada from Todo");
            //var special = await ToJsonAsync(specialqueryable,_context);
            //DataTable dt = (DataTable)JsonConvert.DeserializeObject(special, (typeof(DataTable)));
            EfCoreIndexViewModel vm = new();
            vm.QueryString = query.ToQueryString();
            vm.Todos = todos;
            vm.DataTable = dt;

            return View(vm);
        }

        async Task<string?> ToJsonAsync<T>(IQueryable<T> q, ApplicationDbContext ctx)
        {
            var querystring = q.ToQueryString();
            var qs2 = querystring.Replace(Environment.NewLine, string.Empty);
            var qs3 = qs2 + " FOR JSON AUTO";
            var jsonResults = await ctx.Database.SqlQueryRaw<string?>(qs3).ToListAsync();
            return jsonResults.FirstOrDefault();
        
        }
    }
}
