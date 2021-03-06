using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEvnum.Boleto; }
        }
        public bool EhCartao
        {
            get { return Id == (int)TipoFormaPagamentoEvnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEvnum.Deposito; }
        }
        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEvnum.NaoDefinido; }
        }
    }
}
