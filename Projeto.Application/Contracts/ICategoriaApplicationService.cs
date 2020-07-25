using Projeto.Application.DTOs;
using Projeto.Application.Models.Categorias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface ICategoriaApplicationService
    {
        void Create(CategoriaCadastroModel model);
        void Update(CategoriaEdicaoModel model);
        void Delete(CategoriaExclusaoModel model);

        List<CategoriaDTO> GetAll();
        CategoriaDTO GetById(string id);
    }
}
