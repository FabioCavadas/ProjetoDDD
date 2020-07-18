using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Aggregates.Produtos.Models;
using Projeto.Domain.Aggregates.Usuarios.Models;
using Projeto.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contexts
{
    //REGRA 1) HERDAR DbContext
    public class DataContext : DbContext
    {
        //REGRA 2) Construtor para injeção de dependência
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        //REGRA 3) Declarar um DbSet para cada entidade mapeada
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<UsuarioPerfil> UsuariosPerfis { get; set; }

        //REGRA 4) Adicionar as classes de mapeamento
        //Sobrescrita do método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new UsuarioPerfilMap());

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasIndex(f => f.Cnpj).IsUnique();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(u => u.Email).IsUnique();
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasIndex(p => p.Nome).IsUnique();
            });

        }
    }
}
