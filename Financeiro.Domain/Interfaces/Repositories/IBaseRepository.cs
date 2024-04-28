using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate);

    }
}
