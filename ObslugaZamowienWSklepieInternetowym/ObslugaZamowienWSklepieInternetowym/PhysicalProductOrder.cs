using System;
using System.Collections.Generic;

namespace OrderManagementApp.Model
{
    public class PhysicalProductOrder : IOrder
    {
        public string Id { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public decimal Price { get; set; }
        public string ShippingAddress { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"ZAMÓWIENIE FIZYCZNE [{Id}]\nProdukty: {string.Join(", ", Items)}\nCena: {Price:C}\nAdres dostawy: {ShippingAddress}\n");
        }
    }
}
