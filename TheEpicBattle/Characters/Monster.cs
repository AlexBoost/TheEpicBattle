using System;
using TheEpicBattle.Weapons;
using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Characters
{
    public class Monster : AHumanoide
    {
        private Random _random;
        private int _berserkPercent;
        public Monster(string name, double life, int strenght, int spirit, int dexterity, int dodgePercent, int berserkPercent, AWeapon weapon) : base(name, life, strenght, spirit, dexterity, dodgePercent, weapon)
        {
            _random = new Random();
            _berserkPercent = berserkPercent;
        }

        public override void Attack(ACharacter opponent)
        {
            double damage = Weapon.Damage;

            switch (Weapon.Type)
            {
                case WeaponType.STRENGHT:
                    damage += Strenght;
                    break;
                case WeaponType.SPIRIT:
                    damage += Spirit;
                    break;
                case WeaponType.DEXTERITY:
                    damage += Dexterity;
                    break;
            }

            var luck = _random.Next(0, 101); // 0 => 100

            if (luck < _berserkPercent)
            {
                Console.WriteLine($"##### {Name} EST EN MODE BERSERK (150% de dégats) ! #####");
                damage *= 1.5;
            }

            //Damage defined.
            opponent.BeingAttacked(damage);
        }
    }
}
