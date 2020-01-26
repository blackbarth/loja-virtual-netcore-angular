using System;
using System.Collections.Generic;
using QuickBuy.Domain.ObjetoDeValor;

namespace QuickBuy.Domain.Entities
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public int IdFormaPagamento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}