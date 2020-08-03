using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.DTOs;
using Projeto.Application.Models.Produtos;
using Projeto.Domain.Aggregates.Produtos.Contracts.Services;
using Projeto.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoDomainService produtoDomainService;
        private readonly IMapper mapper;

        public ProdutoApplicationService(IProdutoDomainService produtoDomainService, IMapper mapper)
        {
            this.produtoDomainService = produtoDomainService;
            this.mapper = mapper;
        }

        public void Create(ProdutoCadastroModel model)
        {
            var produto = mapper.Map<Produto>(model);
            produtoDomainService.Create(produto);
        }

        public void Update(ProdutoEdicaoModel model)
        {
            var produto = mapper.Map<Produto>(model);
            produtoDomainService.Update(produto);
        }

        public void Delete(ProdutoExclusaoModel model)
        {
            var idProduto = Guid.Parse(model.IdProduto);
            var produto = produtoDomainService.GetById(idProduto);

            produtoDomainService.Delete(produto);
        }

        public List<ProdutoDTO> GetAll()
        {
            return mapper.Map<List<ProdutoDTO>>
                (produtoDomainService.GetAll());
        }

        public ProdutoDTO GetById(string id)
        {
            return mapper.Map<ProdutoDTO>
                (produtoDomainService.GetById(Guid.Parse(id)));
        }
    }
}






