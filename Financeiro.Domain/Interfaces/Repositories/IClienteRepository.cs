using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        Task<Cliente> CreateCliente(Cliente cliente);
        Task<Cliente> UpdateCliente(Cliente cliente);
        Task<Cliente> DeleteCliente(Cliente cliente);

    }
}
