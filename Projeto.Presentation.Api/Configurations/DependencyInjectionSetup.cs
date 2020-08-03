using Microsoft.Extensions.DependencyInjection;
using Projeto.Application.Contracts;
using Projeto.Application.Services;
using Projeto.CrossCutting.Cryptography;
using Projeto.Domain.Aggregates.Produtos.Contracts.Repositories;
using Projeto.Domain.Aggregates.Produtos.Contracts.Services;
using Projeto.Domain.Aggregates.Produtos.Services;
using Projeto.Domain.Aggregates.Usuarios.Contracts.CrossCutting;
using Projeto.Domain.Aggregates.Usuarios.Contracts.Repositories;
using Projeto.Domain.Aggregates.Usuarios.Contracts.Services;
using Projeto.Domain.Aggregates.Usuarios.Services;
using Projeto.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Configurations
{
    public class DependencyInjectionSetup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region Application

            services.AddTransient<ICategoriaApplicationService, CategoriaApplicationService>();
            services.AddTransient<IFornecedorApplicationService, FornecedorApplicationService>();
            services.AddTransient<IPerfilApplicationService, PerfilApplicationService>();
            services.AddTransient<IProdutoApplicationService, ProdutoApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();

            #endregion

            #region Domain

            services.AddTransient<ICategoriaDomainService, CategoriaDomainService>();
            services.AddTransient<IFornecedorDomainService, FornecedorDomainService>();
            services.AddTransient<IPerfilDomainService, PerfilDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();

            #endregion

            #region InfraStructure

            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IPerfilRepository, PerfilRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IMD5Cryptography, MD5Cryptography>();

            #endregion
        }
    }
}