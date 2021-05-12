using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Weapons
{
    public class Staff : AWeapon
    {
        public Staff(string name, double damage) : base(WeaponType.SPIRIT, name, damage)
        {
        }
    }
}
