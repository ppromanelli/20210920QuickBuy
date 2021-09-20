using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            //  Nome
            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);

            //  Descrição
            builder
                .Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(400);
        }
    }
}
