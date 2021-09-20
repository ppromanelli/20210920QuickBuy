using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            //  Data
            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            //  Data Previsão
            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            //  CEP
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);

            //  Cidade
            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            //  Estado
            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100);

            //  Endereço Completo
            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            //  Numero
            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired();

            //  Forma pagamento ID
            builder
                .Property(p => p.FormaPagamentoId)
                .IsRequired();

            //  Usuario
            //builder
            //    .HasOne(p => p.Usuario);

        }
    }
}
