using OrderManagementApp.Model;
using System;

namespace OrderManagementApp.Factory
{
    public static class OrderFactory
    {
        public static IOrder CreateOrder(string type, string id, string address, string item, decimal price)
        {
            return type switch
            {
                "Physical" => new PhysicalProductOrder 
                    { Id = id, Items = new List<string> { item }, Price = price, ShippingAddress = address },
                "Digital" => new DigitalProductOrder 
                    { Id = id, Items = new List<string> { item }, Price = price, ShippingAddress = address },
                "Service" => new ServiceOrder 
                    { Id = id, Items = new List<string> { item }, Price = price, ShippingAddress = address },
                _ => throw new ArgumentException("Nieznany typ zamówienia")
            };
        }
    }
}
