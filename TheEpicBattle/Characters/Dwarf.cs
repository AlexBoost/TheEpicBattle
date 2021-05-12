using System;
using TheEpicBattle.Weapons;

namespace TheEpicBattle.Characters
{
    public class Dwarf : AHumanoide
    {
        public Dwarf(string name, double life, int strenght, int spirit, int dexterity, int dodgePercent, AWeapon weapon) : base(name, life, strenght, spirit, dexterity, dodgePercent, weapon)
        {
        }

        public override void Attack(ACharacter opponent)
        {
            //ATTAQUE 2 FOIS
            Console.WriteLine($"{Environment.NewLine}####### LES NAINS ATTAQUES DEUX FOIS ! ####### {Environment.NewLine}");
            base.Attack(opponent);
            base.Attack(opponent);
        }
    }
}
