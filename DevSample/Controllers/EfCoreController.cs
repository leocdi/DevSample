using DevSample.Data;
using DevSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Text.Json;

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
            //query simple
            var query = _context.Todos;
            var todos = await query.ToListAsync();

            var s = "select (select * from Todo FOR JSON AUTO) as value";
            var s2 = "select * from Todo FOR JSON AUTO";

            var queryDyn = _context.Database.SqlQueryRaw<string?>(s2);
            var jsonStringList = await queryDyn.ToListAsync();
            var json = jsonStringList.FirstOrDefault();

            var totoDeserialize = System.Text.Json.JsonSerializer.Deserialize<List<Todo>>(json);
            var jsonelementObj = System.Text.Json.JsonSerializer.Deserialize<List<JsonElement>>(json);
            var Obj = System.Text.Json.JsonSerializer.Deserialize<List<object>>(json);
            var dyn = System.Text.Json.JsonSerializer.Deserialize<List<dynamic>>(json);

            var queryDynString = queryDyn.ToQueryString();


            var specialqueryable = _context.Database.SqlQueryRaw<string?>("select *, 1 as uno, 2 as Tada from Todo");
            var special = await ToJsonAsync(specialqueryable,_context);

            var users = await ToJsonAsync(_context.Users, _context);
            EfCoreIndexViewModel vm = new();
            vm.QueryString = query.ToQueryString();
            vm.Todos = todos;
            vm.Dyna = JsonSerializer.Deserialize<List<dynamic>>(special);

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
