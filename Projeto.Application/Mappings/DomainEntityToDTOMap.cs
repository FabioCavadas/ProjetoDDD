using AutoMapper;
using Projeto.Application.DTOs;
using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Mappings
{
    public class DomainEntityToDTOMap : Profile
    {
        public DomainEntityToDTOMap()
        {
            CreateMap<Categoria, CategoriaDTO>()
               .AfterMap((src, dest) => {
                   dest.IdCategoria = src.Id.ToString();
               });

            CreateMap<Fornecedor, FornecedorDTO>()
               .AfterMap((src, dest) => {
                   dest.IdFornecedor = src.Id.ToString();
               });

            CreateMap<Perfil, PerfilDTO>()
               .AfterMap((src, dest) => {
                   dest.IdPerfil = src.Id.ToString();
               });

            CreateMap<Produto, ProdutoDTO>()
               .AfterMap((src, dest) => {
                   dest.IdProduto = src.Id.ToString();
                   dest.Total = (src.Preco * src.Quantidade);
               });

            CreateMap<Usuario, UsuarioDTO>()
               .AfterMap((src, dest) => {
                   dest.IdUsuario = src.Id.ToString();
               });

        }
    }
}
