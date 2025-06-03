using System; 
using RPGGame.Components;

namespace RPGGame.Builder
{
    public class CharacterBuilder
    {
        private CharacterClass _characterClass;
        private Race _race;
        private Abilities _abilities;

        public CharacterBuilder SetCharacterClass(string className)
        {
            _characterClass = new CharacterClass(className);
            return this;
        }

        public CharacterBuilder SetRace(string raceName)
        {
            _race = new Race(raceName);
            return this;
        }

        public CharacterBuilder SetAbilities(string ability)
        {
            _abilities = new Abilities(ability);
            return this;
        }

        public void BuildCharacter()
        {
            Console.WriteLine("Postać została stworzona:");
            _characterClass?.ShowDetails();
            _race?.ShowDetails();
            _abilities?.ShowDetails();
        }
    }
}
