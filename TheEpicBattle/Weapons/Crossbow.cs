using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Weapons
{
    public class Crossbow : AWeapon
    {
        public Crossbow(string name, double damage) : base(WeaponType.DEXTERITY, name, damage)
        {
        }
    }
}
