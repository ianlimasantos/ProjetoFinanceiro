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
        Task<Bank> GetByIdAsync(long id);
        Task<Bank> GetAllAsync();
        Task<Bank> CreateBank(Bank banco);
        Task<Bank> UpdateBank(Bank banco);
        Task<Bank> DeleteBank(long id);

    }
}
