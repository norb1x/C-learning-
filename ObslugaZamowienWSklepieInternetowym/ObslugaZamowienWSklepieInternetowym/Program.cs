using OrderManagementApp.Factory;
using OrderManagementApp.Model;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var orders = new List<IOrder>();

        while (true)
        {
            Console.WriteLine("1. Zamów produkt fizyczny\n2. Zamów produkt cyfrowy\n3. Zamów usługę\n4. Wyjdź z aplikacji");
            var choice = Console.ReadLine();

            if (choice == "4") break;

            Console.Write("Podaj ID zamówienia: ");
            var id = Console.ReadLine();

            Console.Write("Podaj adres dostawy/E-mail/Lokalizację: ");
            var address = Console.ReadLine();

            Console.Write("Podaj nazwę produktu/usługi/pliku: ");
            var item = Console.ReadLine();

            Console.Write("Podaj cenę produktu/usługi/pliku: ");
            var price = decimal.Parse(Console.ReadLine());

            var orderType = choice switch 
            {
                "1" => "Physical",
                "2" => "Digital",
                "3" => "Service",
                _ => throw new ArgumentException("Nieprawidłowy wybór")
            };

            var order = OrderFactory.CreateOrder(orderType, id, address, item, price);
            orders.Add(order);

            order.DisplayDetails();
            Console.WriteLine("Zamówienie zostało złożone.\n");
        }

        Console.WriteLine("Dziękujemy za skorzystanie z naszej aplikacji!");
    }
}
