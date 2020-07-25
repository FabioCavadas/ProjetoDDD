using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models.Produtos
{
    public class ProdutoExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do produto.")]
        public string IdProduto { get; set; }
    }
}
