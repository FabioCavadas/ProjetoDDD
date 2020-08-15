using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models.Produtos;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        //atributo
        private IProdutoApplicationService produtoApplicationService;

        //construtor para injeção de dependência
        public ProdutosController(IProdutoApplicationService produtoApplicationService)
        {
            this.produtoApplicationService = produtoApplicationService;
        }

        [HttpPost]
        public IActionResult Post(ProdutoCadastroModel model)
        {
            try
            {
                var result = produtoApplicationService.Create(model);

                return Ok(new
                {
                    Message = "Produto cadastrado com sucesso.",
                    Produto = result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(ProdutoEdicaoModel model)
        {
            try
            {
                var result = produtoApplicationService.Update(model);

                return Ok(new
                {
                    Message = "Produto atualizado com sucesso.",
                    Produto = result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var model = new ProdutoExclusaoModel() { IdProduto = id };
                var result = produtoApplicationService.Delete(model);

                return Ok(new
                {
                    Message = "Produto excluído com sucesso.",
                    Produto = result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(produtoApplicationService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                return Ok(produtoApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
