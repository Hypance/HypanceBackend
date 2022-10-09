using System;
using System.Linq.Expressions;
using Hypance.Core.Domain;
using Hypance.Data.DataProviders;
using Microsoft.EntityFrameworkCore;

namespace Hypance.Data
{
    public class EntityRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly HypanceDbContext _hypanceDbContext;

        public EntityRepository(HypanceDbContext hypanceDbContext)
        {
            _hypanceDbContext = hypanceDbContext;
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return filter == null ?
                _hypanceDbContext.Set<T>().ToList() :
                _hypanceDbContext.Set<T>().Where(filter).ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            var query = _hypanceDbContext.Set<T>().FirstOrDefault(filter);
            if (query != null)
                return query;

            return default(T);
        }

        public void Add(T entity)
        {
            try
            {
              _hypanceDbContext.Add<T>(entity);
              _hypanceDbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public void Update(T entity)
        {
            _hypanceDbContext.Update<T>(entity);
            _hypanceDbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _hypanceDbContext.Remove<T>(entity);
            _hypanceDbContext.SaveChanges();
        }

    }
}