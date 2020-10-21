using System.Collections.Generic;

namespace TP3.Core.Data.Datatable
{
    public class GridData<t>
    {
        public List<t> List { get; set; }
        public long Count { get; set; }
    }
}
