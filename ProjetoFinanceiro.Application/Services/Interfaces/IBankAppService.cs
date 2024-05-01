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
        Task<BankViewModel> CadastrarBanco(NewBankViewModel novoBancoViewModel);
        Task<BankViewModel> AtualizarBanco(UpdateBankViewModel atualizarBancoViewModel);
        Task<IEnumerable<BankViewModel>> ListarBancos();
        Task<BankViewModel> ListarBancoPorId(long id);
        Task<bool> DeletarBanco(long  id);



    }
}
