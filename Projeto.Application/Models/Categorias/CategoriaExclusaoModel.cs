using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models.Categorias
{
    public class CategoriaExclusaoModel
    {

        [Required(ErrorMessage = "Informe o id categoria.")]
        public string IdCategoria { get; set; }
    }
}
