using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Application.ViewModel
{
    public class AtualizarBancoViewModel
    {
        public long Id {  get; set; }
        public string Codigo { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
