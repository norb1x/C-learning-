using System;

namespace TemperatureMonitorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie czujnika
            var sensor = new TemperatureSensor();

            // Tworzenie obiektów
            var monitorA = new MonitoringObject("Obiekt monitorujący A");
            var monitorB = new MonitoringObject("Obiekt monitorujący B");

            // Dodanie obserwatorów
            sensor.AddObserver(monitorA);
            sensor.AddObserver(monitorB);

            // Wyświetlanie opcji
            DisplayOptions();

            // Symulacja zmian
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nSymulacja zmian temperatury:");
            Console.ResetColor();

            sensor.SetTemperature(25);
            sensor.SetTemperature(30);

            // Usuwanie obserwatora A
            sensor.RemoveObserver(monitorA);

            // Zmiana temperatury
            sensor.SetTemperature(28);
        }

        static void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1. Dodaj obiekt monitorujący A");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2. Dodaj obiekt monitorujący B");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3. Ustaw temperaturę na 25 stopni");
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4. Ustaw temperaturę na 30 stopni");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("5. Usuń obiekt monitorujący A");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("6. Ustaw temperaturę na 28 stopni");
            
            Console.ResetColor();
        }
    }
}
