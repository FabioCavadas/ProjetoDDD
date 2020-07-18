using Projeto.Domain.Aggregates.Produtos.Contracts.Repositories;
using Projeto.Domain.Aggregates.Produtos.Contracts.Services;
using Projeto.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Services
{
    public class CategoriaDomainService : ICategoriaDomainService
    {
        //atributo
        private readonly ICategoriaRepository categoriaRepository;

        //construtor para injeção de dependencia (inicialização)
        public CategoriaDomainService(ICategoriaRepository categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
        }

        public void Create(Categoria obj)
        {
            categoriaRepository.Create(obj);
        }

        public void Update(Categoria obj)
        {
            categoriaRepository.Update(obj);
        }

        public void Delete(Categoria obj)
        {
            categoriaRepository.Delete(obj);
        }

        public List<Categoria> GetAll()
        {
            return categoriaRepository.GetAll();
        }

        public Categoria GetById(Guid id)
        {
            return categoriaRepository.GetById(id);
        }

    }
}
