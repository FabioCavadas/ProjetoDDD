using Projeto.Domain.Aggregates.Produtos.Contracts.Repositories;
using Projeto.Domain.Aggregates.Produtos.Contracts.Services;
using Projeto.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Services
{
    public class FornecedorDomainService : IFornecedorDomainService
    {
        //atributo
        private readonly IFornecedorRepository fornecedorRepository;

        //construtor para injeção de dependência (inicialização)
        public FornecedorDomainService(IFornecedorRepository fornecedorRepository)
        {
            this.fornecedorRepository = fornecedorRepository;
        }

        public void Create(Fornecedor obj)
        {
            fornecedorRepository.Create(obj);
        }

        public void Update(Fornecedor obj)
        {
            fornecedorRepository.Update(obj);
        }

        public void Delete(Fornecedor obj)
        {
            fornecedorRepository.Delete(obj);
        }

        public List<Fornecedor> GetAll()
        {
            return fornecedorRepository.GetAll();
        }

        public Fornecedor GetById(Guid id)
        {
            return fornecedorRepository.GetById(id);
        }
    }
}
