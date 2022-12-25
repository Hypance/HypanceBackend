using System.Linq.Expressions;
using Hypance.SharedKernel.Domain;
using Hypance.SharedKernel.Results;

namespace Hypance.SharedKernel.Repositories
{
	public interface IRepository<T> where T : BaseEntity
    {
        IDataResult<T> Get(Expression<Func<T, bool>> filter);
        IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(int entityId);
	}
}

