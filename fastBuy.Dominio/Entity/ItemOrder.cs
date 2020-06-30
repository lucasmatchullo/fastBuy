using System;

namespace fastBuy.Dominio.Entity
{
    public class ItemOrder : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }

        public override void Validate()
        {
            if (ProductId == 0)
                AddAlert("Product reference not identified!!");

            if (Quantity == 0)
                AddAlert("Quantity not reported!!");

        }
    }
}
