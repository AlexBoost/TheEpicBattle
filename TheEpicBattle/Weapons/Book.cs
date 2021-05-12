using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Weapons
{
    public class Book : AWeapon
    {
        public Book(string name, double damage) : base(WeaponType.SPIRIT, name, damage)
        {
        }
    }
}
