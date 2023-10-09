namespace DevSample.Models
{
    public static class Seeder
    {
        public static List<Employee> SeedDemoEmployeeList()
        {
            List<Employee> list = new()
            {
                new() { Name = "Airi Satou", Id = 1, Position = "Accountant", Office = "Tokyo", Age = 33,StartDate = new DateOnly(2008,11,28), Salary =162700},
                new() { Name = "Angelica Ramos", Id = 2, Position = "Chief Executive Officer (CEO)", Office = "London", Age = 47, StartDate = new DateOnly(2009,10,09), Salary =1200000},
                new() { Name = "Ashton Cox", Id = 3, Position = "Junior Technical Author", Office = "San Francisco", Age = 66,StartDate = new DateOnly(2009,01,12), Salary =86000},
                new() { Name = "Bradley Greer", Id = 4, Position = "Software Engineer", Office = "London", Age = 41,StartDate = new DateOnly(2012,10,13), Salary =132000},
                new() { Name = "Brenden Wagner", Id = 5, Position = "Software Engineer", Office = "San Francisco", Age = 28,StartDate = new DateOnly(2011,06,07), Salary =206850},
                new() { Name = "Brielle Williamson", Id = 6, Position = "Integration Specialist", Office = "New York", Age = 61, StartDate = new DateOnly(2012,12,02), Salary =372000},
                new() { Name = "Bruno Nash", Id = 7, Position = "Software Engineer", Office = "London", Age = 38,StartDate = new DateOnly(2011,05,03), Salary =163500},
                new() { Name = "Caesar Vance", Id = 8, Position = "Pre-Sales Support", Office = "New York", Age = 21,StartDate = new DateOnly(2011,12,12), Salary =106450},
                new() { Name = "Cara Stevens", Id = 9, Position = "Sales Assistant", Office = "New York", Age = 46,StartDate = new DateOnly(2011,12,06), Salary =145600},
                new() { Name = "Cedric Kelly", Id = 10, Position = "Senior Javascript Developer", Office = "Edinburgh", Age = 22,StartDate = new DateOnly(2012,03,29), Salary =433060},
                new() { Name = "Charde Marshall", Id = 11, Position = "Regional Director", Office = "San Francisco", Age = 36,StartDate = new DateOnly(2008,10,16), Salary =470600},
                new() { Name = "Colleen Hurst", Id = 12, Position = "Javascript Developer", Office = "San Francisco", Age = 39,StartDate = new DateOnly(2009,09,15), Salary =205500},
                new() { Name = "Dai Rios", Id = 13, Position = "Personnel Lead", Office = "Edinburgh", Age = 35,StartDate = new DateOnly(2012,09,26), Salary =217500},
                new() { Name = "Donna Snider", Id = 14, Position = "Customer Support", Office = "New York", Age = 27,StartDate = new DateOnly(2011,01,25), Salary =112000},
                new() { Name = "Doris Wilder", Id = 15, Position = "Sales Assistant", Office = "Sydney", Age = 23,StartDate = new DateOnly(2010,09,20), Salary =85600 },
                new() { Name = "Finn Camacho", Id = 16, Position = "Support Engineer", Office = "San Francisco", Age = 47,StartDate = new DateOnly(2009,07,07), Salary =87500},
                new() { Name = "Fiona Green", Id = 17, Position = "Chief Operating Officer (COO)", Office = "San Francisco", Age = 48,StartDate = new DateOnly(2010,03,11), Salary =850000},
                new() { Name = "Garrett Winters", Id = 18, Position = "Accountant", Office = "Tokyo", Age = 63,StartDate = new DateOnly(2011,07,25), Salary =170750 },
                new() { Name = "Gavin Cortez", Id = 19, Position = "Team Leader", Office = "San Francisco", Age = 22,StartDate = new DateOnly(2008,10,26), Salary =235500},
                new() { Name = "Gavin Joyce", Id = 20, Position = "Developer", Office = "Edinburgh", Age = 42,StartDate = new DateOnly(2010,12,22), Salary =92575},
                new() { Name = "Gloria Little", Id = 21, Position = "Systems Administrator", Office = "New York", Age = 59,StartDate = new DateOnly(2009,04,10), Salary =237500},
                new() { Name = "Haley Kennedy", Id = 22, Position = "Senior Marketing Designer", Office = "London", Age = 43,StartDate = new DateOnly(2012,12,18), Salary =313500},
                new() { Name = "Hermione Butler", Id = 23, Position = "Regional Director", Office = "London", Age = 47,StartDate = new DateOnly(2011,03,21), Salary =356250},
                new() { Name = "Herrod Chandler", Id = 24, Position = "Sales Assistant", Office = "San Francisco", Age = 59,StartDate = new DateOnly(2012,08,06), Salary =137500},
                new() { Name = "Hope Fuentes", Id = 25, Position = "Secretary", Office = "San Francisco", Age = 41,StartDate = new DateOnly(2010,02,12), Salary =109850},
                new() { Name = "Howard Hatfield", Id = 26, Position = "Office Manager", Office = "San Francisco", Age = 51,StartDate = new DateOnly(2008,12,16), Salary =164500},
                new() { Name = "Jackson Bradshaw", Id = 27, Position = "Director", Office = "New York", Age = 65,StartDate = new DateOnly(2008,09,26), Salary =645750},
                new() { Name = "Jena Gaines", Id = 28, Position = "Office Manager", Office = "London", Age = 30,StartDate = new DateOnly(2008,12,19), Salary =90560},
                new() { Name = "Jenette Caldwell", Id = 29, Position = "Development Lead", Office = "New York", Age = 30,StartDate = new DateOnly(2011,09,03), Salary =345000},
                new() { Name = "Jennifer Acosta", Id = 30, Position = "Junior Javascript Developer", Office = "Edinburgh", Age = 43,StartDate = new DateOnly(2013,02,01), Salary =75650},
                new() { Name = "Jennifer Chang", Id = 31, Position = "Regional Director", Office = "Singapore", Age = 28,StartDate = new DateOnly(2010,11,14), Salary =357650},
                new() { Name = "Jonas Alexander", Id = 32, Position = "Developer", Office = "San Francisco", Age = 30,StartDate = new DateOnly(2010,07,14), Salary =86500},
                new() { Name = "Lael Greer", Id = 33, Position = "Systems Administrator", Office = "London", Age = 21,StartDate = new DateOnly(2009,02,27), Salary =103500},
                new() { Name = "Martena Mccray", Id = 34, Position = "Post-Sales support", Office = "Edinburgh", Age = 46,StartDate = new DateOnly(2011,03,09), Salary =324050},
                new() { Name = "Michael Bruce", Id = 35, Position = "Javascript Developer", Office = "Singapore", Age = 29,StartDate = new DateOnly(2011,11,27), Salary =183000},
                new() { Name = "Michael Silva", Id = 36, Position = "Marketing Designer", Office = "London", Age = 66,StartDate = new DateOnly(2012,11,27), Salary =198500},
                new() { Name = "Michelle House", Id = 37, Position = "Integration Specialist", Office = "Sydney", Age = 37,StartDate = new DateOnly(2011,06,02), Salary =95400},
                new() { Name = "Olivia Liang", Id = 38, Position = "Support Engineer", Office = "Singapore", Age = 64,StartDate = new DateOnly(2011,02,03), Salary =234500},
                new() { Name = "Paul Byrd", Id = 39, Position = "Chief Financial Officer (CFO)", Office = "New York", Age = 64,StartDate = new DateOnly(2010,06,09), Salary =725000},
                new() { Name = "Prescott Bartlett", Id = 40, Position = "Technical Author", Office = "London", Age = 27,StartDate = new DateOnly(2011,05,07), Salary =145000},
                new() { Name = "Quinn Flynn", Id = 41, Position = "Support Lead", Office = "Edinburgh", Age = 22,StartDate = new DateOnly(2013,03,03), Salary =342000},
                new() { Name = "Rhona Davidson", Id = 42, Position = "Integration Specialist", Office = "Tokyo", Age = 55,StartDate = new DateOnly(2010,10,14), Salary =327900},
                new() { Name = "Sakura Yamamoto", Id = 43, Position = "Support Engineer", Office = "Tokyo", Age = 37,StartDate = new DateOnly(2009,08,19), Salary =139575},
                new() { Name = "Serge Baldwin", Id = 44, Position = "Data Coordinator", Office = "Singapore", Age = 64,StartDate = new DateOnly(2012,04,09), Salary =138575},
                new() { Name = "Shad Decker", Id = 45, Position = "Regional Director", Office = "Edinburgh", Age = 51,StartDate = new DateOnly(2008,11,13), Salary =183000},
                new() { Name = "Shou Itou", Id = 46, Position = "Regional Marketing", Office = "Tokyo", Age = 20,StartDate = new DateOnly(2011,08,14), Salary =163000},
                new() { Name = "Sonya Frost", Id = 47, Position = "Software Engineer", Office = "Edinburgh", Age = 23,StartDate = new DateOnly(2008,12,13), Salary =103600},
                new() { Name = "Suki Burks", Id = 48, Position = "Developer", Office = "London", Age = 53,StartDate = new DateOnly(2009,10,22), Salary =114500},
                new() { Name = "Tatyana Fitzpatrick", Id = 49, Position = "Regional Director", Office = "London", Age = 19,StartDate = new DateOnly(2010,03,17), Salary =385750},
                new() { Name = "Thor Walton", Id = 50, Position = "Developer", Office = "New York", Age = 61,StartDate = new DateOnly(2013,08,11), Salary =98540},
                new() { Name = "Tiger Nixon", Id = 51, Position = "System Architect", Office = "Edinburgh", Age = 61,StartDate = new DateOnly(2011,04,25), Salary =320800},
                new() { Name = "Timothy Mooney", Id = 52, Position = "Office Manager", Office = "London", Age = 37,StartDate = new DateOnly(2008,12,11), Salary =136200},
                new() { Name = "Unity Butler", Id = 53, Position = "Marketing Designer", Office = "San Francisco", Age = 47,StartDate = new DateOnly(2009,12,09), Salary =85675},
                new() { Name = "Vivian Harrell", Id = 54, Position = "Financial Controller", Office = "San Francisco", Age = 62,StartDate = new DateOnly(2009,02,14), Salary =452500},
                new() { Name = "Yuri Berry", Id = 55, Position = "Chief Marketing Officer (CMO)", Office = "New York", Age = 40,StartDate = new DateOnly(2009,06,25), Salary =675000},
                new() { Name = "Zenaida Frank", Id = 56, Position = "Software Engineer", Office = "New York", Age = 63,StartDate = new DateOnly(2010,01,04), Salary =125250},
                new() { Name = "Zorita Serrano", Id = 57, Position = "Software Engineer", Office = "San Francisco", Age = 56,StartDate = new DateOnly(2012,06,01), Salary =115000 }
            };

            return list;
        }

        public static DatatableConfig SeedDatatableConfig()
        {
            var features = new List<Feature>
            {
                new (){ Name = "autoWidth", Desc = "Feature control DataTables' smart column width handling.", OptionDefault = "true", OptionType = ""},
                new (){ Name = "deferRender", Desc = "Feature control deferred rendering for additional speed of initialisation.", OptionDefault = "false"},
                new (){ Name = "info", Desc = "Feature control table information display field.", OptionDefault = "true"},
                new (){ Name = "lengthChange", Desc = "Feature control the end user's ability to change the paging display length of the table.", OptionDefault = "true"},
                new (){ Name = "ordering", Desc = "Feature control ordering (sorting) abilities in DataTables.", OptionDefault = "true"},
                new (){ Name = "paging", Desc = "Enable or disable table pagination.", OptionDefault = "true"},
                new (){ Name = "processing", Desc = "Feature control the processing indicator.", OptionDefault = "false"},
                new (){ Name = "scrollX", Desc = "Horizontal scrolling.", OptionDefault = "false"},
                new (){ Name = "scrollY", Desc = "Vertical scrolling.", OptionDefault = "", OptionHint="Default value is '' (empty string). Can be initialized like this 'scrollY': '200px'"},
                new (){ Name = "searching", Desc = "Feature control search (filtering) abilities.", OptionDefault = "true"},
                new (){ Name = "serverSide", Desc = "Feature control DataTables' server-side processing mode.", OptionDefault = "false"},
                new (){ Name = "stateSave", Desc = "State saving - restore table state on page reload.", OptionDefault = "false"},
                new (){ Name = "fixedHeader", Desc = "Fix the table header to the top of a scrolling window.", OptionDefault = "true"},
            };


            return new DatatableConfig 
            {
                Features = features
            };
        }

        public static DatatableSampleViewModel SeedDatatableSampleViewModel()
        {
            return  new DatatableSampleViewModel()
            {
                DatatableConfiguration = SeedDatatableConfig(),
                Employees = SeedDemoEmployeeList(),
            };
        }

        public static DatatableSampleViewModel SeedEmptyDatatableSampleViewModel()
        {
            return new DatatableSampleViewModel()
            {
                DatatableConfiguration = SeedDatatableConfig(),
                Employees = new(),
            };
        }
    }
}
