using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IDebtRepository
    {
        Task<Debt> CreateDivida(Debt divida);
        Task<Debt> UpdateDivida(Debt divida);
        Task<Debt> DeleteDivida(Debt divida);
    }
}
