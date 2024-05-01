using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Services
{
    public interface IBankService
    {
        Task<Banco> GetByIdAsync(long id);
        Task<Banco> GetAllAsync();
        Task<Banco> CreateBank(Banco banco);
        Task<Banco> UpdateBank(Banco banco);
        Task<Banco> DeleteBank(long id);

    }
}
