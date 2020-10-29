using TP3.Domain.Entities;
using TP3.Domain.Entities.Datatable;

namespace TP3.Domain.Interfaces
{
    public interface IChallengeRepository : IRepository<Challenge>
    {
        PagingResult<Challenge> GetFilteredByPage(int offset, int pageSize, string filter, string orderBy, string sortDirection, string user);
    }
}
