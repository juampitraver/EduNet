using System;
using System.Collections.Generic;
using System.Linq;
using TP3.Domain.Entities;
using TP3.Domain.Entities.Datatable;
using TP3.Domain.Interfaces;

namespace TP3.Infrastructure.Implementations
{
    public class ChallengeRepository : Repository<Challenge>, IChallengeRepository
    {
        protected Context _context { get; set; }
        public ChallengeRepository(Context context) : base(context)
        {
            _context = context;
        }

        private static readonly Dictionary<string, Func<IQueryable<Challenge>, IQueryable<Challenge>>> orderByDictionary = new Dictionary<string, Func<IQueryable<Challenge>, IQueryable<Challenge>>>
        {
            { string.Empty, x => x.OrderBy(o => o.Id) },
            { "IdASC", x => x.OrderBy(o => o.Id) },
            { "IdDESC", x => x.OrderByDescending(o => o.Id) },
            { "TitleASC", x => x.OrderBy(o => o.Title) },
            { "TitleDESC", x => x.OrderByDescending(o => o.Title) }
        };

        public PagingResult<Challenge> GetFilteredByPage(int offset, int pageSize, string filter, string orderBy, string sortDirection, string user)
        {
            //clear filter
            if (string.IsNullOrWhiteSpace(filter))
                filter = string.Empty;

            //get query 
            var query = base.FindByCondition(x => x.IsActive && x.User.Name.ToUpper().Trim().Equals(user.ToUpper().Trim()));

            //apply filter
            query = query.Where(x => x.Id.ToString().Contains(filter) ||
                                     x.Title.Contains(filter));

            //apply order
            orderBy = string.Format("{0}{1}", orderBy, sortDirection);
            query = orderByDictionary[orderBy](query);

            //return paged result
            return base.GetPagedList(query, offset, pageSize);
        }

    }
}
