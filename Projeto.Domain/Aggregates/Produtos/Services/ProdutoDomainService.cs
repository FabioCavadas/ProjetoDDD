using Projeto.Domain.Aggregates.Produtos.Contracts.Repositories;
using Projeto.Domain.Aggregates.Produtos.Contracts.Services;
using Projeto.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Services
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        //atributo
        private readonly IProdutoRepository produtoRepository;

        //construtor para injeção de dependência (inicialização)
        public ProdutoDomainService(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public void Create(Produto obj)
        {
            produtoRepository.Create(obj);
        }

        public void Update(Produto obj)
        {
            produtoRepository.Update(obj);
        }

        public void Delete(Produto obj)
        {
            produtoRepository.Delete(obj);
        }

        public List<Produto> GetAll()
        {
            return produtoRepository.GetAll();
        }

        public Produto GetById(Guid id)
        {
            return produtoRepository.GetById(id);
        }
    }
}