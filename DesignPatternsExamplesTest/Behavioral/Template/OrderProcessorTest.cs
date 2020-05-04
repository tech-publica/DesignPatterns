using DesignPatterns.Behavioural.Template;
using Xunit;

namespace DesignPatternsExamplesTest.Behavioral.Template
{

    public class OrderProcessorTest
    {
        public static readonly decimal EXPECTED_FOREIGN_SHIP_COST = 100;
        public static readonly decimal EXPECTED_DOMESTIC_SHIP_COST = 50;
        public static readonly decimal COST = 2000;


        [Fact]
        public void ProcessDomesticOrder()
        {
            OrderProcessor processor = new DomesticOrderProcessor();
            Order order = new Order()
            {
                Id = 1,
                Cost = COST
            };
            processor.Process(order);
            Assert.Equal(COST, order.Cost);
            Assert.Equal(COST + EXPECTED_DOMESTIC_SHIP_COST, order.TotalCost);
            Assert.Equal(ShippingMethod.FLASH, order.ShippingMethod);
            Assert.Equal(PaymentMethod.CC, order.PaymentMethod);
        }
        [Fact]
        public void ProcessForeignOrder()
        {
            OrderProcessor processor = new ForeignOrderProcessor();
            Order order = new Order()
            {
                Id = 1,
                Cost = COST
            };
            processor.Process(order);
            Assert.Equal(COST, order.Cost);
            Assert.Equal(COST + EXPECTED_FOREIGN_SHIP_COST, order.TotalCost);
            Assert.Equal(ShippingMethod.KIND_OF_SLOW, order.ShippingMethod);
            Assert.Equal(PaymentMethod.BA, order.PaymentMethod);
        }

    }
}