using System;
using System.Linq.Expressions;
using Hypance.Core.Domain;
using Hypance.Core.Utilites;
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

        public IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter)
        {
            try
            {
                var data = filter == null ?
                _hypanceDbContext.Set<T>().ToList() :
                _hypanceDbContext.Set<T>().Where(filter).ToList();
                return new SuccessDataResult<List<T>>(data);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<List<T>>(ex.Message);
            }
        }

        public IDataResult<T> Get(Expression<Func<T, bool>> filter)
        {
            try
            {
                var query = _hypanceDbContext.Set<T>().FirstOrDefault(filter);
                return new SuccessDataResult<T>(query);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<T>(ex.Message);
            }
        }

        public IResult Add(T entity)
        {
            try
            {
                _hypanceDbContext.Add<T>(entity);
                _hypanceDbContext.SaveChanges();
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }

        }

        public IResult Update(T entity)
        {
            try
            {
                _hypanceDbContext.Update<T>(entity);
                _hypanceDbContext.SaveChanges();
                return new SuccessResult();
            }
            catch (System.Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(T entity)
        {
            try
            {
                _hypanceDbContext.Remove<T>(entity);
                _hypanceDbContext.SaveChanges();
                return new SuccessResult();
            }
            catch (System.Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

    }
}