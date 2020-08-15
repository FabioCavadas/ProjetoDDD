using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models.Fornecedores;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        //atributo
        private IFornecedorApplicationService fornecedorApplicationService;

        //construtor para injeção de dependência
        public FornecedoresController(IFornecedorApplicationService fornecedorApplicationService)
        {
            this.fornecedorApplicationService = fornecedorApplicationService;
        }

        [HttpPost]
        public IActionResult Post(FornecedorCadastroModel model)
        {
            try
            {
                var result = fornecedorApplicationService.Create(model);

                return Ok(new
                {
                    Message = "Fornecedor cadastrado com sucesso.",
                    Fornecedor = result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(FornecedorEdicaoModel model)
        {
            try
            {
                var result = fornecedorApplicationService.Update(model);

                return Ok(new
                {
                    Message = "Fornecedor atualizado com sucesso.",
                    Fornecedor = result
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
                var model = new FornecedorExclusaoModel() { IdFornecedor = id };

                var result = fornecedorApplicationService.Delete(model);

                return Ok(new
                {
                    Message = "Fornecedor excluído com sucesso.",
                    Fornecedor = result
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
                return Ok(fornecedorApplicationService.GetAll());
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
                return Ok(fornecedorApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
