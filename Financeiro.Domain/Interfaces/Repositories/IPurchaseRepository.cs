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
        Task<Purchase> CreateCliente(Purchase cliente);
        Task<Purchase> UpdateCliente(Purchase cliente);
        Task<Purchase> DeleteCliente(Purchase cliente);
    }
}
