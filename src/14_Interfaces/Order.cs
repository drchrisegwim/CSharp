using System;

namespace _14_Interfaces
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped { get;  set; }
    }
}