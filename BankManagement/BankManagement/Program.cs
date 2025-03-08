using System;

namespace BankManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = BankClientsManager.Instance;

            while (true)
            {
                Console.WriteLine("\nWitaj w systemie zarządzania klientami banku!");
                Console.WriteLine("1. Dodaj nowego klienta");
                Console.WriteLine("2. Usuń istniejącego klienta");
                Console.WriteLine("3. Wyświetl listę klientów");
                Console.WriteLine("4. Wyjdź z aplikacji");
                Console.Write("Wybierz opcję: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddClient(manager);
                        break;
                    case "2":
                        RemoveClient(manager);
                        break;
                    case "3":
                        manager.DisplayClients();
                        break;
                    case "4":
                        Console.WriteLine("Dziękujemy za skorzystanie z naszej aplikacji!");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }

        static void AddClient(BankClientsManager manager)
        {
            Console.Write("Podaj imię nowego klienta: ");
            var firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko nowego klienta: ");
            var lastName = Console.ReadLine();

            Console.Write("Podaj saldo konta nowego klienta: ");
            if (decimal.TryParse(Console.ReadLine(), out var balance))
            {
                manager.AddClient(firstName, lastName, balance);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość salda.");
            }
        }

        static void RemoveClient(BankClientsManager manager)
        {
            Console.Write("Podaj ID klienta do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out var id))
            {
                manager.RemoveClient(id);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość ID.");
            }
        }
    }
}
