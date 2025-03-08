using System;

namespace TemperatureMonitorApp
{
    public class MonitoringObject : ITemperatureObserver
    {
        private string _name;

        public MonitoringObject(string name)
        {
            _name = name;
        }

        public void Update(int temperature)
        {
            Console.Write($"{_name}: Temperatura wynosi ");
            
            // Kolor1
            Console.ForegroundColor = temperature switch
            {
                25 => ConsoleColor.Magenta,
                30 => ConsoleColor.Red,
                28 => ConsoleColor.Cyan,
                _ => ConsoleColor.White
            };

            Console.Write($"{temperature} ");
            
            //  Kolor2
            Console.ResetColor();
            
            Console.WriteLine("stopni");
        }
    }
}
