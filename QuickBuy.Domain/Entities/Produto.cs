namespace QuickBuy.Domain.Entities
{
    public class Produto : Entidade
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}