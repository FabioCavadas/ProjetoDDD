using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models.Fornecedores
{
    public class FornecedorEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id do fornecedor.")]
        public string IdFornecedor { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o nome do fornecedor.")]
        public string Nome { get; set; }

        [RegularExpression("^[0-9]{14}$", ErrorMessage = "Informe exatamente 14 dígitos.")]
        [Required(ErrorMessage = "Informe o cnpj do fornecedor.")]
        public string Cnpj { get; set; }
    }
}
