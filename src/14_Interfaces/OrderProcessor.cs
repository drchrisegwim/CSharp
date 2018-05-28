using System;

namespace _14_Interfaces
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator;

        public OrderProcessor()
        {
            this._shippingCalculator= new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if(order.IsShipped)
                throw new InvalidOperationException("This Order is already processed!!!");
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
            throw new NotImplementedException();
        }
    }
}