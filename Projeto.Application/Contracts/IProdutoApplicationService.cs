using Projeto.Application.DTOs;
using Projeto.Application.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IProdutoApplicationService
    {
        void Create(ProdutoCadastroModel model);
        void Update(ProdutoEdicaoModel model);
        void Delete(ProdutoExclusaoModel model);

        List<ProdutoDTO> GetAll();
        ProdutoDTO GetById(string id);
    }
}
