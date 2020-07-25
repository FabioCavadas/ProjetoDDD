using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models.Fornecedores
{
    public class FornecedorExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do fornecedor.")]
        public string IdFornecedor { get; set; }
    }
}
