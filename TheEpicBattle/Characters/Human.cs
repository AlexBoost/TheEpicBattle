using TheEpicBattle.Weapons;

namespace TheEpicBattle.Characters
{
    public class Human : AHumanoide
    {
        public Human(string name, double life, int strenght, int spirit, int dexterity, int dodgePercent, AWeapon weapon) : base(name, life, strenght, spirit, dexterity, dodgePercent, weapon)
        {
        }
    }
}
