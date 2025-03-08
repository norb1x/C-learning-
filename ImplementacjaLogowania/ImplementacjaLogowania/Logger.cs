using System;

namespace ImplementacjaLogowania
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = 
            new Lazy<Logger>(() => new Logger());
        
        public static Logger Instance => _instance.Value;
        
        // Dodaj publiczną właściwość do sprawdzania stanu instancji
        public static bool InstanceExists => _instance.IsValueCreated;

        private Logger() 
        {
            Console.WriteLine("Utworzono instancję loggera!");
        }

        public void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"[LOG] {timestamp}: {message}");
        }
    }
}
