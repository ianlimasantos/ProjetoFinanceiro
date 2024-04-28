using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IDividaRepository
    {
        Task<Divida> CreateDivida(Divida divida);
        Task<Divida> UpdateDivida(Divida divida);
        Task<Divida> DeleteDivida(Divida divida);
    }
}
