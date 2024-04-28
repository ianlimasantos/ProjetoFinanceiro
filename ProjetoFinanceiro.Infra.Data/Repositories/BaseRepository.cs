using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Domain.Interfaces;
using ProjetoFinanceiro.Domain.Interfaces.Repositories;
using ProjetoFinanceiro.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Infra.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly FinanceiroContext _context;
        public BaseRepository(FinanceiroContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await _context.Set<T>().FindAsync();
        }
    }
}
