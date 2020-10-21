using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using TP3.Domain.Entities;
using TP3.Domain.Entities.Datatable;
using TP3.Domain.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace TP3.Infrastructure.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected Context RepositoryContext { get; set; }

        public Repository(Context repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> result = this.RepositoryContext.Set<T>();
            if (include != null)
            {
                result = include(result);
            }
            if (typeof(IsActivable).IsAssignableFrom(typeof(T)))
            {
                var parameter = Expression.Parameter(typeof(T));
                var property = Expression.Property(parameter, "IsActive");
                var propAsObject = Expression.Convert(property, typeof(bool));
                var expression = Expression.Lambda<Func<T, bool>>(propAsObject, parameter);
                result = result.Where(expression);
            }
            return result.AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool isAsNotTracking = true )
        {
            IQueryable<T> result = this.RepositoryContext.Set<T>();
            if (include != null)
            {
                result = include(result);
            }
            if (typeof(IsActivable).IsAssignableFrom(typeof(T)))
            {
                var parameter = Expression.Parameter(typeof(T));
                var property = Expression.Property(parameter, "IsActive");
                var propAsObject = Expression.Convert(property, typeof(bool));
                var expressionIsActive = Expression.Lambda<Func<T, bool>>(propAsObject, parameter);
                result = result.Where(expressionIsActive);
            }
            if (isAsNotTracking)
            {
                return result.Where(expression).AsNoTracking();
            }
            else
            {
                return result.Where(expression);
            }
            
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
        }

        public void Disable(T entity)
        {
            if (typeof(IsActivable).IsAssignableFrom(typeof(T)))
                entity.GetType().GetProperty("IsActive").SetValue(entity, false);
            Update(entity);
        }

        public PagingResult<T> GetPagedList(IQueryable<T> query, int offset, int pageSize)
        {
            return new PagingResult<T>
            {
                Count = query.Count(),
                Results = query.Skip(offset).Take(pageSize).ToList()
            };
        }

        public bool Save()
        {
             return this.RepositoryContext.SaveChanges() > 0;
        }
    }
}
