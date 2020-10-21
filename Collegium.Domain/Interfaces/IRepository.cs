using Microsoft.EntityFrameworkCore.Query;
using TP3.Domain.Entities.Datatable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TP3.Domain.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> FindAll(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool isAsNotTracking = true);
        PagingResult<T> GetPagedList(IQueryable<T> query, int offset, int pageSize);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool Save();
        void Disable(T entity);
    }
}
