using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.DTOs;
using Projeto.Application.Models.Categorias;
using Projeto.Domain.Aggregates.Produtos.Contracts.Services;
using Projeto.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class CategoriaApplicationService : ICategoriaApplicationService
    {
        //atributos
        private readonly ICategoriaDomainService categoriaDomainService;
        private readonly IMapper mapper;

        //construtor para injeção de dependência
        public CategoriaApplicationService(ICategoriaDomainService categoriaDomainService, IMapper mapper)
        {
            this.categoriaDomainService = categoriaDomainService;
            this.mapper = mapper;
        }

        public void Create(CategoriaCadastroModel model)
        {
            var categoria = mapper.Map<Categoria>(model);
            categoriaDomainService.Create(categoria);
        }

        public void Update(CategoriaEdicaoModel model)
        {
            var categoria = mapper.Map<Categoria>(model);
            categoriaDomainService.Update(categoria);
        }

        public void Delete(CategoriaExclusaoModel model)
        {
            var id = Guid.Parse(model.IdCategoria);
            var categoria = categoriaDomainService.GetById(id);

            categoriaDomainService.Delete(categoria);
        }

        public List<CategoriaDTO> GetAll()
        {
            return mapper.Map<List<CategoriaDTO>>
                (categoriaDomainService.GetAll());
        }

        public CategoriaDTO GetById(string id)
        {
            return mapper.Map<CategoriaDTO>
                (categoriaDomainService.GetById(Guid.Parse(id)));
        }
    }
}
