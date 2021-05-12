using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Weapons
{
    public class Sword : AWeapon
    {
        public Sword(string name, double damage) : base(WeaponType.STRENGHT, name, damage)
        {
        }
    }
}
