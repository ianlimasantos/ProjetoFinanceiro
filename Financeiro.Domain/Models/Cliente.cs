using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Models
{
    public class Cliente
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email {  get; private set; }
    }
}
