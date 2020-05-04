using System;

namespace DesignPatterns.Behavioural.Template
{
    public abstract class OrderProcessor
    {
        public abstract void ProcessPayment(Order order);
        public abstract void ChooseShippingMethod(Order order);
        public abstract void ApplyShippingCost(Order order);

        public void Process(Order order)
        {
            // calculate total    same for everyone 
            // process payment 
            // update stock       same for everyone  
            // choose shipping method and apply shipping cost
            // notify customer    same for everyone
            Console.WriteLine("calculating total");
            ProcessPayment(order);
            Console.WriteLine("updating stock");
            ChooseShippingMethod(order);
            ApplyShippingCost(order);
            Console.WriteLine("notifying customer");

        }
    }
}