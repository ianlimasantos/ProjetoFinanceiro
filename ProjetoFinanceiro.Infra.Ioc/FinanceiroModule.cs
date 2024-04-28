using Microsoft.Extensions.DependencyInjection;
using ProjetoFinanceiro.Domain.Interfaces.Repositories;
using ProjetoFinanceiro.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Infra.Ioc
{
    public static class FinanceiroModule
    {

        public static IServiceCollection ConfigureApplicationServices (this IServiceCollection services) {

            services.AddScoped<IBancoRepository, BancoRepository>();
            return services;
        }

    }
}
