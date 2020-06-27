namespace fastBuy.Dominio.ValuableObject
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsSlip
        {
             get { return Id == (int)Enumerated.EnumeratedFormPaymentType.Slip; }
        }

        public bool IsCreditCard
        {
            get { return Id == (int)Enumerated.EnumeratedFormPaymentType.CreditCard; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)Enumerated.EnumeratedFormPaymentType.Deposit; }
        }

        public bool IsUndefined
        {
            get { return Id == (int)Enumerated.EnumeratedFormPaymentType.Undefined; }
        }
    }
}
