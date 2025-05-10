using System;
using UserManagement.Models;  // Dodaj to, jeśli klasa User znajduje się w przestrzeni nazw Models

class Program
{
    static void Main(string[] args)
    {
        // Utworzenie instancji fasady do zarządzania użytkownikami
        UserFacade userFacade = new UserFacade();

        // Menu interakcji
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Zaktualizuj użytkownika");
            Console.WriteLine("3. Usuń użytkownika");
            Console.WriteLine("4. Wyjście");
            Console.Write("Wybór: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Dodawanie nowego użytkownika
                    AddUser(userFacade);
                    break;

                case "2":
                    // Aktualizacja użytkownika
                    UpdateUser(userFacade);
                    break;

                case "3":
                    // Usunięcie użytkownika
                    DeleteUser(userFacade);
                    break;

                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                    break;
            }
        }
    }

    // Metoda do dodawania użytkownika
    static void AddUser(UserFacade userFacade)
    {
        Console.WriteLine("Podaj dane użytkownika:");
        Console.Write("Imię: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        var newUser = new User { Name = name, Email = email };
        userFacade.AddUser(newUser);

        Console.WriteLine($"Dodano użytkownika: {newUser.Name} - {newUser.Email}");
        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu.");
        Console.ReadKey();
    }

    // Metoda do aktualizacji użytkownika
    static void UpdateUser(UserFacade userFacade)
    {
        Console.Write("Podaj ID użytkownika do zaktualizowania: ");
        int userId = int.Parse(Console.ReadLine());

        Console.Write("Podaj nowe imię: ");
        string name = Console.ReadLine();
        Console.Write("Podaj nowy email: ");
        string email = Console.ReadLine();

        var user = new User { Id = userId, Name = name, Email = email };
        userFacade.UpdateUser(user);

        Console.WriteLine($"Zaktualizowano użytkownika: {user.Name} - {user.Email}");
        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu.");
        Console.ReadKey();
    }

    // Metoda do usuwania użytkownika
    static void DeleteUser(UserFacade userFacade)
    {
        Console.Write("Podaj ID użytkownika do usunięcia: ");
        int userId = int.Parse(Console.ReadLine());

        userFacade.DeleteUser(userId);
        Console.WriteLine($"Usunięto użytkownika o ID: {userId}");
        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu.");
        Console.ReadKey();
    }
}
