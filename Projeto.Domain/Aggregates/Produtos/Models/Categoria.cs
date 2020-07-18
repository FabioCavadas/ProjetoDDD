using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Aggregates.Produtos.Models
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }


        #region Relacionamentos

        public List<Produto> Produtos { get; set; }

        #endregion
    }
}
