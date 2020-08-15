
using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.DTOs;
using Projeto.Application.Models.Fornecedores;
using Projeto.Domain.Aggregates.Produtos.Contracts.Services;
using Projeto.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        //atributos
        private readonly IFornecedorDomainService fornecedorDomainService;
        private readonly IMapper mapper;

        //construtor para injeção de dependência
        public FornecedorApplicationService(IFornecedorDomainService fornecedorDomainService, IMapper mapper)
        {
            this.fornecedorDomainService = fornecedorDomainService;
            this.mapper = mapper;
        }

        public FornecedorDTO Create(FornecedorCadastroModel model)
        {
            var fornecedor = mapper.Map<Fornecedor>(model);
            fornecedorDomainService.Create(fornecedor);

            return mapper.Map<FornecedorDTO>(fornecedor);
        }

        public FornecedorDTO Update(FornecedorEdicaoModel model)
        {
            var fornecedor = mapper.Map<Fornecedor>(model);
            fornecedorDomainService.Update(fornecedor);

            return mapper.Map<FornecedorDTO>(fornecedor);
        }

        public FornecedorDTO Delete(FornecedorExclusaoModel model)
        {
            var idFornecedor = Guid.Parse(model.IdFornecedor);
            var fornecedor = fornecedorDomainService.GetById(idFornecedor);

            fornecedorDomainService.Delete(fornecedor);

            return mapper.Map<FornecedorDTO>(fornecedor);
        }

        public List<FornecedorDTO> GetAll()
        {
            return mapper.Map<List<FornecedorDTO>>
                (fornecedorDomainService.GetAll());
        }

        public FornecedorDTO GetById(string id)
        {
            return mapper.Map<FornecedorDTO>
                (fornecedorDomainService.GetById(Guid.Parse(id)));
        }
    }
}