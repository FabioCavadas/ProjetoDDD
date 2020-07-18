using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Contracts.Services
{
    public interface ICategoriaDomainService : IBaseDomainService<Categoria>
    {

    }
}


/*
 using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Contracts.Services
{
    public interface ICategoriaDomainService : IBaseDomainService<Categoria>
    {

    }
}


====================

using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Contracts.Services
{
    public interface IFornecedorDomainService : IBaseDomainService<Fornecedor>
    {

    }
}


====================

using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Contracts.Services
{
    public interface IProdutoDomainService : IBaseDomainService<Produto>
    {

    }
}


=======================

using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Bases
{
    public interface IBaseDomainService<TEntity>
        where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        List<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}


=======================


 */


