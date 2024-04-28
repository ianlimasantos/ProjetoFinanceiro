using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IBancoRepository: IBaseRepository<Banco>
    {
        Task<Banco> CreateCliente(Banco cliente);
        Task<Banco> UpdateCliente(Banco cliente);
        Task<Banco> DeleteCliente(Banco cliente);
    }
}
