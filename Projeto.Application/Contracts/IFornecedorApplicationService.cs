using Projeto.Application.DTOs;
using Projeto.Application.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IFornecedorApplicationService
    {
        void Create(FornecedorCadastroModel model);
        void Update(FornecedorEdicaoModel model);
        void Delete(FornecedorExclusaoModel model);

        List<FornecedorDTO> GetAll();
        FornecedorDTO GetById(string id);
    }
}
