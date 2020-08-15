using Projeto.Application.DTOs;
using Projeto.Application.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IFornecedorApplicationService
    {
        FornecedorDTO Create(FornecedorCadastroModel model);
        FornecedorDTO Update(FornecedorEdicaoModel model);
        FornecedorDTO Delete(FornecedorExclusaoModel model);
        List<FornecedorDTO> GetAll();
        FornecedorDTO GetById(string id);
    }
}
