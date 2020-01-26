using QuickBuy.Domain.Enumerados;

namespace QuickBuy.Domain.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int IdFormaPagamento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamento.Boleto; }
        }
        public bool EhCartaoCredito
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamento.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamento.Deposito; }
        }
        public bool NaoFoiDefinido
        {
            get { return IdFormaPagamento == (int)TipoFormaPagamento.NaoDefinido; }
        }

    }
}