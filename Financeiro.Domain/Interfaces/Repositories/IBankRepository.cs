using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IBankRepository: IBaseRepository<Bank>
    {
        Task<Bank> CreateBank(Bank cliente);
        Task<Bank> UpdateBank(Bank cliente);
        Task<Bank> DeleteBank(Bank cliente);
    }
}
