using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Infra.Data.EF.Maps
{
    public class BancoMapping : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.Nome)
                .IsRequired();

            builder.Property(x => x.Codigo)
                .IsRequired();
        }
    }
}
