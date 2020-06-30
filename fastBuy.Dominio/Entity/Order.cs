using fastBuy.Dominio.ValuableObject;
using System;
using System.Collections.Generic;

namespace fastBuy.Dominio.Entity
{
    public class Order : Entity
    {
        public int Id { get; set; }
        public DateTime DateRequest { get; set; }
        public int UserId { get; set; }
        public string CompleteAddress { get; set; }
        public int NumberAddress { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CEP { get; set; }
        public int PaymentFormId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<ItemOrder> ItensOrder { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (!ItemOrder.Any())
                AddAlert("Order item cannot be empty!!");

            if (string.IsNullOrEmpty(CEP)) 
                AddAlert("CEP cannot be empty!!");

            if (PaymentFormId == 0)
                AddAlert("Form of payment not informed!!");

        }
    }
}
