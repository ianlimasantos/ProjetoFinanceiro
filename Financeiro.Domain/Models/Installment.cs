using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Models
{
    public class Installment
    {
        public long Id { get; private set; }
        public long CompraId { get; private set; }
        public bool FoiPaga { get; private set; }
        public DateTime Vencimento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public virtual Purchase Compra { get; private set; }
    }
}
