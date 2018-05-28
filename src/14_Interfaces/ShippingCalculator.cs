using System;

namespace _14_Interfaces
{
    public class ShippingCalculator
    {
        internal float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}