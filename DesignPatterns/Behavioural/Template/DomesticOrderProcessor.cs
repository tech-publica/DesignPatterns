using System;
namespace DesignPatterns.Behavioural.Template
{
    public class DomesticOrderProcessor : OrderProcessor
    {
        public static readonly decimal STANDARD_SHIP_COST = 50;

        public override void ApplyShippingCost(Order order)
        {
            order.ShippingCost = STANDARD_SHIP_COST;
        }

        public override void ChooseShippingMethod(Order order)
        {
            order.ShippingMethod = ShippingMethod.FLASH;
        }

        public override void ProcessPayment(Order order)
        {
            order.PaymentMethod = PaymentMethod.CC;
        }

        

       
    }
}