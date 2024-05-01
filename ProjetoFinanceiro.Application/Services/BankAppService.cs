using ProjetoFinanceiro.Application.Services.Interfaces;
using ProjetoFinanceiro.Application.ViewModel;
using ProjetoFinanceiro.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Application.Services
{
    public class BankAppService : IBankAppService
    {
        private IBankService _service;

        public BankAppService(IBankService service)
        {
            _service = service;
        }

        public Task<BankViewModel> CadastrarBanco(NewBankViewModel novoBancoViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<BankViewModel> AtualizarBanco(UpdateBankViewModel atualizarBancoViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarBanco(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BankViewModel>> ListarBancos()
        {
            throw new NotImplementedException();
        }

        public Task<BankViewModel> ListarBancoPorId(long id)
        {
            throw new NotImplementedException();
        }
    }
}
