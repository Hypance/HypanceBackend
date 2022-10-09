using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
using Hypance.Core.Domain;

namespace Hypance.Data
{
	public interface IRepository<T> where T : BaseEntity
    {
		T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}

