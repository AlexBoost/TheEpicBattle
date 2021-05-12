using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Weapons
{
    public class Axe : AWeapon
    {
        public Axe(string name, double damage) : base(WeaponType.STRENGHT, name, damage)
        {
        }
    }
}
