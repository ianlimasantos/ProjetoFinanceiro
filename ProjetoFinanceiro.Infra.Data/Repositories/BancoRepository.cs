using ProjetoFinanceiro.Domain.Interfaces.Repositories;
using ProjetoFinanceiro.Domain.Models;
using ProjetoFinanceiro.Infra.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Infra.Data.Repositories
{
    public class BancoRepository : BaseRepository<Bank>, IBankRepository
    {
        private readonly FinanceiroContext _context;

        public BancoRepository(FinanceiroContext context) : base(context) 
        {
            _context = context;
        }

        public Task<Bank> CreateBank(Bank cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Bank> DeleteBank(Bank cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Bank> UpdateBank(Bank cliente)
        {
            throw new NotImplementedException();
        }
    }
}
