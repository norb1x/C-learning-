using System; 

namespace RPGGame.Components
{
    public class CharacterClass
    {
        public string ClassName { get; private set; }

        public CharacterClass(string className)
        {
            ClassName = className;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Klasa postaci: {ClassName}");
        }
    }
}
