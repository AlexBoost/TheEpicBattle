using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Weapons
{
    public class Bow : AWeapon
    {
        public Bow(string name, double damage) : base(WeaponType.DEXTERITY, name, damage)
        {
        }
    }
}
