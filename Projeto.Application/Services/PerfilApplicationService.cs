using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.DTOs;
using Projeto.Application.Models.Perfis;
using Projeto.Domain.Aggregates.Usuarios.Contracts.Services;
using Projeto.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class PerfilApplicationService : IPerfilApplicationService
    {
        private readonly IPerfilDomainService perfilDomainService;
        private readonly IMapper mapper;

        public PerfilApplicationService(IPerfilDomainService perfilDomainService, IMapper mapper)
        {
            this.perfilDomainService = perfilDomainService;
            this.mapper = mapper;
        }

        public void Create(PerfilCadastroModel model)
        {
            var perfil = mapper.Map<Perfil>(model);
            perfilDomainService.Create(perfil);
        }

        public void Update(PerfilEdicaoModel model)
        {
            var perfil = mapper.Map<Perfil>(model);
            perfilDomainService.Update(perfil);
        }

        public void Delete(PerfilExclusaoModel model)
        {
            var idPerfil = Guid.Parse(model.IdPerfil);
            var perfil = perfilDomainService.GetById(idPerfil);

            perfilDomainService.Delete(perfil);
        }

        public List<PerfilDTO> GetAll()
        {
            return mapper.Map<List<PerfilDTO>>
                (perfilDomainService.GetAll());
        }

        public PerfilDTO GetById(string id)
        {
            return mapper.Map<PerfilDTO>
                (perfilDomainService.GetById(Guid.Parse(id)));
        }
    }
}


