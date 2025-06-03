using System; 

namespace RPGGame.Components
{
    public class Race
    {
        public string RaceName { get; private set; }

        public Race(string raceName)
        {
            RaceName = raceName;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Rasa postaci: {RaceName}");
        }
    }
}
