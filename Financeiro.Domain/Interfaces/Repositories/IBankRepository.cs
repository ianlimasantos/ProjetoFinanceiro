using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IBankRepository: IBaseRepository<Banco>
    {
        Task<Banco> CreateBank(Banco cliente);
        Task<Banco> UpdateBank(Banco cliente);
        Task<Banco> DeleteBank(Banco cliente);
    }
}
