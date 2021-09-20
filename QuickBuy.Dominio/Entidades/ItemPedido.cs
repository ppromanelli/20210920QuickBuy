using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido:Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
            {
                AdicionarMensagem("Critica: Sem ProdutoId");
            }

            if (Quantidade == 0)
            {
                AdicionarMensagem("Critica: Sem Quantidade");
            }
        }
    }
}
