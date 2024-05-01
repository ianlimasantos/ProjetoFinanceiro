using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public float Preco { get; private set; }
        public bool EmEstoque {  get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
    }
}
