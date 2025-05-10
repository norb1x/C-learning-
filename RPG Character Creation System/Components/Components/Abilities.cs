using System; // Dodano brakującą przestrzeń nazw

namespace RPGGame.Components
{
    public class Abilities
    {
        public string Ability { get; private set; }

        public Abilities(string ability)
        {
            Ability = ability;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Umiejętność: {Ability}");
        }
    }
}
