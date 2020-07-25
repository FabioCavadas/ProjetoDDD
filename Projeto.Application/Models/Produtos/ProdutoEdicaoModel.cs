using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models.Produtos
{
    public class ProdutoEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id do produto.")]
        public string IdProduto { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(25, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o nome do produto.")]
        public string Nome { get; set; }

        [RegularExpression("^[0-9.,]{1,10}$", ErrorMessage = "Informe um preço válido.")]
        [Required(ErrorMessage = "Informe o preço do produto.")]
        public string Preco { get; set; }

        [RegularExpression("^[0-9]{1,9}$", ErrorMessage = "Informe uma quantidade válida.")]
        [Required(ErrorMessage = "Informe a quantidade do produto.")]
        public string Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o id do fornecedor.")]
        public string IdFornecedor { get; set; }

        [Required(ErrorMessage = "Informe o id da categoria.")]
        public string IdCategoria { get; set; }
    }
}
