using System;
using System.Collections.Generic;

namespace OrderManagementApp.Model
{
    public class ServiceOrder : IOrder
    {
        public string Id { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public decimal Price { get; set; }
        public string ShippingAddress { get; set; } // Lokalizacja usługi

        public void DisplayDetails()
        {
            Console.WriteLine($"ZAMÓWIENIE USŁUGI [{Id}]\nUsługi: {string.Join(", ", Items)}\nKoszt: {Price:C}\nLokalizacja: {ShippingAddress}\n");
        }
    }
}
