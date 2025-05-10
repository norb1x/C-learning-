using System;
using RPGGame.Builder;
using RPGGame.Components;

class Program
{
    static void Main(string[] args)
    {
        var builder = new CharacterBuilder();
        bool exit = false;

        // Definicja dostępnych klas, ras i umiejętności
        var availableClasses = new string[] { "Wojownik", "Mag", "Łucznik" };
        var availableRaces = new string[] { "Człowiek", "Elf", "Ork" };
        var availableAbilities = new string[] { "Walka wręcz", "Magia", "Strzelectwo" };

        Console.WriteLine("Tworzenie postaci w grze RPG");

        while (!exit)
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Stwórz klasę postaci");
            Console.WriteLine("2. Wybierz rasę postaci");
            Console.WriteLine("3. Wybierz umiejętność");
            Console.WriteLine("4. Stwórz postać");
            Console.WriteLine("5. Zakończ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Wybierz klasę postaci:");
                    for (int i = 0; i < availableClasses.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {availableClasses[i]}");
                    }
                    int classChoice = int.Parse(Console.ReadLine());
                    builder.SetCharacterClass(availableClasses[classChoice - 1]);
                    break;

                case "2":
                    Console.WriteLine("Wybierz rasę postaci:");
                    for (int i = 0; i < availableRaces.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {availableRaces[i]}");
                    }
                    int raceChoice = int.Parse(Console.ReadLine());
                    builder.SetRace(availableRaces[raceChoice - 1]);
                    break;

                case "3":
                    Console.WriteLine("Wybierz umiejętność:");
                    for (int i = 0; i < availableAbilities.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {availableAbilities[i]}");
                    }
                    int abilityChoice = int.Parse(Console.ReadLine());
                    builder.SetAbilities(availableAbilities[abilityChoice - 1]);
                    break;

                case "4":
                    builder.BuildCharacter();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Zakończono program.");
                    break;

                default:
                    Console.WriteLine("Niepoprawny wybór, spróbuj ponownie.");
                    break;
            }
        }
    }
}
