﻿namespace QuickBuy.Domain.Entities
{
    public class ItemPedido : Entidade
    {
        public int IdItemProduto { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}