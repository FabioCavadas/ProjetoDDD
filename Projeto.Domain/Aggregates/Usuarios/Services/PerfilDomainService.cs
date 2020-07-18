using Projeto.Domain.Aggregates.Usuarios.Contracts.Repositories;
using Projeto.Domain.Aggregates.Usuarios.Contracts.Services;
using Projeto.Domain.Aggregates.Usuarios.Exceptions;
using Projeto.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Usuarios.Services
{
    public class PerfilDomainService : IPerfilDomainService
    {
        //atributo
        private readonly IPerfilRepository perfilRepository;

        //construtor para injeção de dependência
        public PerfilDomainService(IPerfilRepository perfilRepository)
        {
            this.perfilRepository = perfilRepository;
        }

        public void Create(Perfil obj)
        {
            //verificando se ja existe um perfil cadastrado com o nome informado
            if (perfilRepository.Count(p => p.Nome.Equals(obj.Nome)) > 0)
                throw new PerfilUnicoException();

            //cadastrar o perfil
            perfilRepository.Create(obj);
        }

        public void Update(Perfil obj)
        {
            perfilRepository.Update(obj);
        }

        public void Delete(Perfil obj)
        {
            perfilRepository.Delete(obj);
        }

        public List<Perfil> GetAll()
        {
            return perfilRepository.GetAll();
        }

        public Perfil GetById(Guid id)
        {
            return perfilRepository.GetById(id);
        }
    }
}
