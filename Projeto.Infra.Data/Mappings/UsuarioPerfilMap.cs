using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class UsuarioPerfilMap : IEntityTypeConfiguration<UsuarioPerfil>
    {
        public void Configure(EntityTypeBuilder<UsuarioPerfil> builder)
        {
            builder.ToTable("UsuarioPerfil");

            builder.HasKey(up => new
            {
                //chave primária composta
                up.UsuarioId,
                up.PerfilId
            });

            builder.Property(up => up.UsuarioId)
                .HasColumnName("UsuarioId")
                .IsRequired();

            builder.Property(up => up.PerfilId)
                .HasColumnName("PerfilId")
                .IsRequired();

            #region Relacionamentos

            builder.HasOne(up => up.Usuario)
                .WithMany(u => u.Perfis)
                .HasForeignKey(up => up.UsuarioId);

            builder.HasOne(up => up.Perfil)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(up => up.PerfilId);

            #endregion
        }
    }
}



