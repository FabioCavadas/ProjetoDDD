using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models.Categorias;

namespace Projeto.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        //atributo
        private readonly ICategoriaApplicationService categoriaApplicationService;

        //construtor para injeção de dependência
        public CategoriasController(ICategoriaApplicationService categoriaApplicationService)
        {
            this.categoriaApplicationService = categoriaApplicationService;
        }

        [HttpPost]
        public IActionResult Post(CategoriaCadastroModel model)
        {
            try
            {
                var result = categoriaApplicationService.Create(model);

                return Ok(new
                {
                    Message = "Categoria cadastrado com sucesso.",
                    Categoria = result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(CategoriaEdicaoModel model)
        {
            try
            {
                var result = categoriaApplicationService.Update(model);

                return Ok(new
                {
                    Message = "Categoria atualizado com sucesso.",
                    Categoria = result
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
                var model = new CategoriaExclusaoModel() { IdCategoria = id };
                var result = categoriaApplicationService.Delete(model);

                return Ok(new
                {
                    Message = "Categoria excluído com sucesso.",
                    Categoria = result
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
                return Ok(categoriaApplicationService.GetAll());
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
                return Ok(categoriaApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}