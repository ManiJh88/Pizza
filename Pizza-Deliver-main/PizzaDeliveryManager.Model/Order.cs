using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaDeliveryManager.Model
{
    public class Order
    {
        public string CustomerName { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Topping { get; set; }
        public int Quantity { get; set; }
        public string DeliveryBoy { get; set; }
        public DateTime DateTime { get; set; }
    }
}
