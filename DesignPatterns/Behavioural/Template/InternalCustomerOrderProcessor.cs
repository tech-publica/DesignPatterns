using System;
namespace DesignPatterns.Behavioural.Template
{
    public class InternalCustomerOrderProcessor : OrderProcessor
    {
        public static readonly decimal STANDARD_SHIP_COST = 0;

        public override void ApplyShippingCost(Order order)
        {
            order.ShippingCost = STANDARD_SHIP_COST;
        }
        public override void ChooseShippingMethod(Order order)
        {
            order.ShippingMethod = ShippingMethod.DECENT;
        }
        public override void ProcessPayment(Order order)
        {
            order.PaymentMethod = PaymentMethod.CC;
        }
    }
}