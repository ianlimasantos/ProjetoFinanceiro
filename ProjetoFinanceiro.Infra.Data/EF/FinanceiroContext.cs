using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Domain.Interfaces;
using ProjetoFinanceiro.Domain.Models;
using ProjetoFinanceiro.Infra.Data.EF.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Infra.Data.EF
{
    public class FinanceiroContext : DbContext, IUnitOfWork
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new BancoMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Banco> Bancos { get; set; }

    }
}
