using System;

namespace ImplementacjaLogowania
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            logger.Log("Aplikacja uruchomiona");

            // Próba utworzenia drugiej instancji
            try
            {
                Logger anotherLogger = Logger.Instance;
                anotherLogger.Log("Próba użycia drugiej instancji");
            }
            catch (Exception ex)
            {
                Logger.Instance.Log($"Błąd tworzenia instancji: {ex.GetType().Name} - {ex.Message}");
            }

            Logger.Instance.Log("Użytkownik zalogowany");
            
            // Weryfikacja działania singletona
            Console.WriteLine("\nWeryfikacja działania wzorca Singleton:");
            Console.WriteLine($"Czy obiekty są identyczne? {logger == Logger.Instance}");
            Console.WriteLine($"Liczba utworzonych instancji: {(Logger.InstanceExists ? 1 : 0)}"); // Użyj właściwości InstanceExists
        }
    }
}
