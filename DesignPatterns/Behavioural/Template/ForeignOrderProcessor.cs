using System;
namespace DesignPatterns.Behavioural.Template
{
    public class ForeignOrderProcessor : OrderProcessor
    {
        public static readonly decimal STANDARD_SHIP_COST = 100;

        public override void ApplyShippingCost(Order order)
        {
            order.ShippingCost = STANDARD_SHIP_COST;
        }
        public override void ChooseShippingMethod(Order order)
        {
            order.ShippingMethod = ShippingMethod.KIND_OF_SLOW;
        }
        public override void ProcessPayment(Order order)
        {
            order.PaymentMethod = PaymentMethod.BA;
        }
    }
}