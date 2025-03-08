using System;
using System.Collections.Generic;

namespace BankManagementApp
{
    public sealed class BankClientsManager
    {
        private static readonly Lazy<BankClientsManager> _instance = 
            new Lazy<BankClientsManager>(() => new BankClientsManager());

        // Lista klientów
        private readonly List<Client> _clients = new List<Client>();
        private int _nextId = 1;

       
        private BankClientsManager() { }

        
        public static BankClientsManager Instance => _instance.Value;

        // Dodaj klienta
        public void AddClient(string firstName, string lastName, decimal balance)
        {
            var client = new Client
            {
                Id = _nextId++,
                FirstName = firstName,
                LastName = lastName,
                Balance = balance
            };
            _clients.Add(client);
            Console.WriteLine("Nowy klient został dodany!");
        }

        // Usuń klienta po ID
        public void RemoveClient(int id)
        {
            var client = _clients.Find(c => c.Id == id);
            if (client != null)
            {
                _clients.Remove(client);
                Console.WriteLine("Klient został usunięty!");
            }
            else
            {
                Console.WriteLine("Nie znaleziono klienta o podanym ID.");
            }
        }

        // Wyświetl listę klientów
        public void DisplayClients()
        {
            if (_clients.Count == 0)
            {
                Console.WriteLine("Brak klientów w systemie.");
                return;
            }

            Console.WriteLine("Lista klientów:");
            foreach (var client in _clients)
            {
                Console.WriteLine(client);
            }
        }
    }
}
