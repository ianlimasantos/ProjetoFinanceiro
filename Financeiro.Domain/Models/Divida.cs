using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Models
{
    public class Divida
    {
        public long Id { get; private set; }
        public long ClienteId  { get; private set; }
        public long ParcelasId { get; private set; }
        public long ValorDividaAtrasada { get; private set; }
        public long ValorDividaNoPrazo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public Cliente Clientes { get; private set; }
        public ICollection<Parcela> Parcelas { get; private set;}

    }
}
