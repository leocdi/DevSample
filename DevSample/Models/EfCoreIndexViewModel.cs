
using DevSample.Data;
using System.Data;

namespace DevSample.Models
{
    public class EfCoreIndexViewModel
    {
        public string? QueryString { get;set; }
        public List<Todo> Todos { get; set; } = new List<Todo>();
        public string? Result { get; set; }
        public DataTable DataTable { get; set; }
    }
}
