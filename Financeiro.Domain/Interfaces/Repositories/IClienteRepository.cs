using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IClienteRepository : IBaseRepository<Client>
    {
        Task<Client> CreateCliente(Client cliente);
        Task<Client> UpdateCliente(Client cliente);
        Task<Client> DeleteCliente(Client cliente);

    }
}
