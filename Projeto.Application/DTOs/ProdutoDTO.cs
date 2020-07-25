using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.DTOs
{
    public class ProdutoDTO
    {
        public string IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }

        public FornecedorDTO Fornecedor { get; set; }
        public CategoriaDTO Categoria { get; set; }
    }
}
