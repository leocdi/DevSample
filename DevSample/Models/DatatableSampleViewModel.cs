namespace DevSample.Models
{
    public class DatatableSampleViewModel
    {

        public List<Employee> Employees { get; set; }
        public DatatableConfig DatatableConfiguration { get; set; }
    }


    public class Feature
    {
        public string Name { get; set; }
        public string OptionType { get; set; }
        public string OptionDefault { get; set; }
        public string OptionHint { get; set; }
        public string Desc { get; set; }
    }

    public class DatatableConfig
    {
        public List<Feature> Features { get; set; } = new ();
    }
}
