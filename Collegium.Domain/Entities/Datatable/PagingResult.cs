using System.Collections.Generic;

namespace TP3.Domain.Entities.Datatable
{
    public class PagingResult<TDomainObject>
    {
        public long Count { get; set; }
        public IList<TDomainObject> Results { get; set; }
    }
}
