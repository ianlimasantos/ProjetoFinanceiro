using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Models
{
    public class Debt
    {
        public long Id { get; private set; }
        public long ClienteId  { get; private set; }
        public long ParcelasId { get; private set; }
        public long ValorDividaAtrasada { get; private set; }
        public long ValorDividaNoPrazo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public Client Clientes { get; private set; }
        public ICollection<Installment> Parcelas { get; private set;}

    }
}
