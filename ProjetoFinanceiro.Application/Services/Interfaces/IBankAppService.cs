using ProjetoFinanceiro.Application.ViewModel;
using ProjetoFinanceiro.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Application.Services.Interfaces
{
    public interface IBankAppService
    {
        Task<BancoViewModel> CadastrarBanco(NovoBancoViewModel novoBancoViewModel);
        Task<BancoViewModel> AtualizarBanco(AtualizarBancoViewModel atualizarBancoViewModel);
        Task<IEnumerable<BancoViewModel>> ListarBancos();
        Task<BancoViewModel> ListarBancoPorId(long id);
        Task<bool> DeletarBanco(long  id);



    }
}
