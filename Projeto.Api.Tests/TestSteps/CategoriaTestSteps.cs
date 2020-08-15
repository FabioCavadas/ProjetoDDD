using FluentAssertions;
using Newtonsoft.Json;
using Projeto.Api.Tests.Contexts;
using Projeto.Api.Tests.Responses;
using Projeto.Api.Tests.Utils;
using Projeto.Application.DTOs;
using Projeto.Application.Models.Categorias;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Projeto.Api.Tests.TestSteps
{
    public class CategoriaTestSteps
    {
        private readonly TestContext testContext;
        private const string resource = "api/Categorias";

        public CategoriaTestSteps()
        {
            testContext = new TestContext();
        }

        [Fact]
        public async Task CadastrarCategoria()
        {
            var model = new CategoriaCadastroModel
            {
                Descricao = "Categoria Teste"
            };

            var request = HttpClientUtil.CreateContent(model);
            var response = await testContext.HttpClient.PostAsync(resource, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var result = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(response));

            result.Message.Should().Be("Categoria cadastrado com sucesso.");
            result.Categoria.IdCategoria.Should().NotBeNullOrEmpty();
            result.Categoria.Descricao.Should().Be(model.Descricao);
        }

        [Fact]
        public async Task AtualizarCategoria()
        {
            //1) cadastrando uma categoria
            var modelCadastro = new CategoriaCadastroModel
            {
                Descricao = "Categoria Teste"
            };

            var requestCadastro = HttpClientUtil.CreateContent(modelCadastro);
            var responseCadastro = await testContext.HttpClient.PostAsync(resource, requestCadastro);

            var resultCadastro = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseCadastro));

            //2) atualizando a categoria cadastrada
            var modelEdicao = new CategoriaEdicaoModel
            {
                IdCategoria = resultCadastro.Categoria.IdCategoria,
                Descricao = "Categoria Teste Atualização"
            };

            var requestEdicao = HttpClientUtil.CreateContent(modelEdicao);
            var responseEdicao = await testContext.HttpClient.PutAsync(resource, requestEdicao);

            responseEdicao.StatusCode.Should().Be(HttpStatusCode.OK);

            var resultEdicao = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseEdicao));

            resultEdicao.Message.Should().Be("Categoria atualizado com sucesso.");
            resultEdicao.Categoria.IdCategoria.Should().Be(modelEdicao.IdCategoria);
            resultEdicao.Categoria.Descricao.Should().Be(modelEdicao.Descricao);
        }

        [Fact]
        public async Task ExcluirCategoria()
        {
            //1) cadastrando uma categoria
            var modelCadastro = new CategoriaCadastroModel
            {
                Descricao = "Categoria Teste"
            };

            var requestCadastro = HttpClientUtil.CreateContent(modelCadastro);
            var responseCadastro = await testContext.HttpClient.PostAsync(resource, requestCadastro);

            var resultCadastro = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseCadastro));

            //2) excluindo a categoria cadastrada        
            var responseExclusao = await testContext.HttpClient
                .DeleteAsync(resource + "/" + resultCadastro.Categoria.IdCategoria);

            responseExclusao.StatusCode.Should().Be(HttpStatusCode.OK);

            var resultExclusao = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseExclusao));

            resultExclusao.Message.Should().Be("Categoria excluído com sucesso.");
            resultExclusao.Categoria.IdCategoria.Should().Be(resultCadastro.Categoria.IdCategoria);
            resultExclusao.Categoria.Descricao.Should().Be(resultCadastro.Categoria.Descricao);
        }

        [Fact]
        public async Task ConsultarCategorias()
        {
            var response = await testContext.HttpClient.GetAsync(resource);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task ObterCategoriaPorId()
        {
            //1) cadastrando uma categoria
            var modelCadastro = new CategoriaCadastroModel
            {
                Descricao = "Categoria Teste"
            };

            var requestCadastro = HttpClientUtil.CreateContent(modelCadastro);
            var responseCadastro = await testContext.HttpClient.PostAsync(resource, requestCadastro);

            var resultCadastro = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseCadastro));

            //2) consulta a categoria cadastrada pelo id        
            var responseConsulta = await testContext.HttpClient
                .GetAsync(resource + "/" + resultCadastro.Categoria.IdCategoria);

            responseConsulta.StatusCode.Should().Be(HttpStatusCode.OK);

            var resultConsulta = JsonConvert.DeserializeObject<CategoriaDTO>
                (HttpClientUtil.GetContent(responseConsulta));

            resultConsulta.IdCategoria.Should().Be(resultCadastro.Categoria.IdCategoria);
            resultConsulta.Descricao.Should().Be(resultCadastro.Categoria.Descricao);
        }
    }
}


