using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Interfaces.Repositories
{
    public interface IPurchaseRepository
    {
        Task<Compra> CreateCliente(Compra cliente);
        Task<Compra> UpdateCliente(Compra cliente);
        Task<Compra> DeleteCliente(Compra cliente);
    }
}
