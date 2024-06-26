﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Models
{
    public class Purchase
    {
        public long Id { get; private set; }
        public long ClienteId {  get; private set; }
        public long ProdutoId {  get; private set; }
        public long BancoId { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public virtual ICollection<Client> Clientes { get; private set; }
        public virtual ICollection<Product> Produtos { get; private set; }
        public virtual ICollection<Bank> Bancos { get; private set; }
    }
}
