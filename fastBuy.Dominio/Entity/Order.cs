using fastBuy.Dominio.ValuableObject;
using System;
using System.Collections.Generic;

namespace fastBuy.Dominio.Entity
{
    public class Order
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

    }
}
