using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models.Categorias
{
    public class CategoriaEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id categoria.")]
        public string IdCategoria { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(250, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe a descrição da categoria.")]
        public string Descricao { get; set; }
    }
}
