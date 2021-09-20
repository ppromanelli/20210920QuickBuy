﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            //  Nome
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            //  Descrição
            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            //  Preço
            builder
                .Property(p => p.Preco)
                .IsRequired();

        }
    }
}
