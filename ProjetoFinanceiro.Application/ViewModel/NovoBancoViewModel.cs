using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Application.ViewModel
{
    public class NovoBancoViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
