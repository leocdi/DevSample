using Microsoft.Extensions.Logging.Abstractions;

namespace DevSample.Models
{
    public class MigrationViewModel
    {
        public string Script { get; set; } = null!;
        public List<string> Migrations { get; set; } = new List<string>();
        public List<string> PendingMigrations { get; set; } = new List<string>();
    }
}
