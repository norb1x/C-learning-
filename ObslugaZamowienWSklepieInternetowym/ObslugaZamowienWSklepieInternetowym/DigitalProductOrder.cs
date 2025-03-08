using System;
using System.Collections.Generic;

namespace OrderManagementApp.Model
{
    public class DigitalProductOrder : IOrder
    {
        public string Id { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public decimal Price { get; set; }
        public string ShippingAddress { get; set; } // E-mail zamiast adresu fizycznego

        public void DisplayDetails()
        {
            Console.WriteLine($"ZAMÓWIENIE CYFROWE [{Id}]\nPliki: {string.Join(", ", Items)}\nCena: {Price:C}\nE-mail: {ShippingAddress}\n");
        }
    }
}
