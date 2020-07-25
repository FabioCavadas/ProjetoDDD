using Projeto.Application.DTOs;
using Projeto.Application.Models.Perfis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IPerfilApplicationService
    {
        void Create(PerfilCadastroModel model);
        void Update(PerfilEdicaoModel model);
        void Delete(PerfilExclusaoModel model);

        List<PerfilDTO> GetAll();
        PerfilDTO GetById(string id);
    }
}
