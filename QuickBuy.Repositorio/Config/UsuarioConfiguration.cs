using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            //  Email
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            //  Senha
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            //  Nome
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);

            //  Sobrenome
            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);

            // Pedidos
            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
