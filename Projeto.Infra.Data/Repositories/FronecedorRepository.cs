using Projeto.Domain.Aggregates.Produtos.Contracts.Repositories;
using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class FornecedorRepository
        : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly DataContext dataContext;

        public FornecedorRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}