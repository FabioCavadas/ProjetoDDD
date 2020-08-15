using FluentAssertions;
using Newtonsoft.Json;
using Projeto.Api.Tests.Contexts;
using Projeto.Api.Tests.Responses;
using Projeto.Api.Tests.Utils;
using Projeto.Application.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Projeto.Api.Tests.TestSteps
{
    public class FornecedorTestSteps
    {
        private readonly TestContext testContext;
        private const string resource = "api/Fornecedores";

        public FornecedorTestSteps()
        {
            testContext = new TestContext();
        }

        [Fact]
        public async Task CadastrarFornecedor()
        {
            var model = new FornecedorCadastroModel
            {
                Cnpj = $"{new Random().Next(9999999)}{new Random().Next(9999999)}",
                Nome = "Fornecedor Teste"
            };

            var request = HttpClientUtil.CreateContent(model);
            var response = await testContext.HttpClient.PostAsync(resource, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var result = JsonConvert.DeserializeObject<FornecedorResponse>
                (HttpClientUtil.GetContent(response));

            result.Message.Should().Be("Fornecedor cadastrado com sucesso.");
            result.Fornecedor.IdFornecedor.Should().NotBeNullOrEmpty();
            result.Fornecedor.Cnpj.Should().Be(model.Cnpj);
            result.Fornecedor.Nome.Should().Be(model.Nome);
        }

        [Fact(Skip = "Não implementado.")]
        public async Task AtualizarFornecedor()
        {

        }

        [Fact(Skip = "Não implementado.")]
        public async Task ExcluirFornecedor()
        {

        }

        [Fact]
        public async Task ConsultarFornecedores()
        {
            var response = await testContext.HttpClient.GetAsync(resource);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact(Skip = "Não implementado.")]
        public async Task ObterFornecedorPorId()
        {

        }
    }
}

