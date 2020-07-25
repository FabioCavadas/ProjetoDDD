using AutoMapper;
using Projeto.Application.Models.Categorias;
using Projeto.Application.Models.Fornecedores;
using Projeto.Application.Models.Perfis;
using Projeto.Application.Models.Produtos;
using Projeto.Application.Models.Usuarios;
using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Mappings
{
    public class ModelToDomainEntityMap : Profile
    {

        public ModelToDomainEntityMap()
        {
            #region Categorias

            CreateMap<CategoriaCadastroModel, Categoria>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.NewGuid();
                });

            CreateMap<CategoriaEdicaoModel, Categoria>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.Parse(src.IdCategoria);
                });

            #endregion

            #region Fornecedores

            CreateMap<FornecedorCadastroModel, Fornecedor>()
               .AfterMap((src, dest) =>
               {
                   dest.Id = Guid.NewGuid();
               });

            CreateMap<FornecedorEdicaoModel, Fornecedor>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.Parse(src.IdFornecedor);
                });

            #endregion

            #region Perfis

            CreateMap<PerfilCadastroModel, Perfil>()
              .AfterMap((src, dest) =>
              {
                  dest.Id = Guid.NewGuid();
              });

            CreateMap<PerfilEdicaoModel, Perfil>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.Parse(src.IdPerfil);
                });

            #endregion

            #region Produtos

            CreateMap<ProdutoCadastroModel, Produto>()
              .AfterMap((src, dest) =>
              {
                  dest.Id = Guid.NewGuid();
                  dest.Preco = decimal.Parse(src.Preco);
                  dest.Quantidade = int.Parse(src.Quantidade);
                  dest.CategoriaId = Guid.Parse(src.IdCategoria);
                  dest.FornecedorId = Guid.Parse(src.IdFornecedor);
              });

            CreateMap<ProdutoEdicaoModel, Produto>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.Parse(src.IdProduto);
                    dest.Preco = decimal.Parse(src.Preco);
                    dest.Quantidade = int.Parse(src.Quantidade);
                    dest.CategoriaId = Guid.Parse(src.IdCategoria);
                    dest.FornecedorId = Guid.Parse(src.IdFornecedor);
                });

            #endregion

            #region Usuarios

            CreateMap<UsuarioCadastroModel, Usuario>()
              .AfterMap((src, dest) =>
              {
                  dest.Id = Guid.NewGuid();
                  dest.DataCriacao = DateTime.Now;
              });

            CreateMap<UsuarioEdicaoModel, Usuario>()
              .AfterMap((src, dest) =>
              {
                  dest.Id = Guid.Parse(src.IdUsuario);
                  dest.DataCriacao = DateTime.Now;
              });

            #endregion

        }
    }
}

