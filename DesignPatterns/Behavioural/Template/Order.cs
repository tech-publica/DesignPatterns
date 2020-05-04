namespace DesignPatterns.Behavioural.Template
{
    public enum PaymentMethod {CC, BA}
    public enum ShippingMethod { FLASH, DECENT, KIND_OF_SLOW }
    public class Order
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ShippingMethod ShippingMethod {get; set;}

        public decimal ShippingCost {get; set;}
        public decimal TotalCost {
            get 
            {
                return Cost + ShippingCost;
            }
        }
    }
}