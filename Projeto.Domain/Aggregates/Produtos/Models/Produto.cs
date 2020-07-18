using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Guid FornecedorId { get; set; }
        public Guid CategoriaId { get; set; }

        #region Relacionamentos

        public Fornecedor Fornecedor { get; set; }
        public Categoria Categoria { get; set; }

        #endregion
    }
}
