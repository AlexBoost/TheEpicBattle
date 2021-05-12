using TheEpicBattle.Weapons;
using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Characters
{
    public abstract class AHumanoide : ACharacter
    {
        public AWeapon Weapon { get; private set; }

        protected AHumanoide(string name, double life, int strenght, int spirit, int dexterity, int dodgePercent, AWeapon weapon) : base(name, life, strenght, spirit, dexterity, dodgePercent)
        {
            Weapon = weapon;
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

            //Damage defined.
            opponent.BeingAttacked(damage);
        }
    }
}
