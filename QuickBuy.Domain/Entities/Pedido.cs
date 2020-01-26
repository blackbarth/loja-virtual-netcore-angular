using System;
using System.Collections.Generic;
using System.Linq;
using QuickBuy.Domain.ObjetoDeValor;

namespace QuickBuy.Domain.Entities
{
    public class Pedido : Entidade
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

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItensPedido.Any())
                AdicionarCritica("Pedido tem que ter no minimo 1 item");
            if(string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP é obrigatorio");
        }
    }
}