using TheEpicBattle.Weapons.Enums;

namespace TheEpicBattle.Weapons
{
    public abstract class AWeapon
    {
        public WeaponType Type { get; private set; }
        public string Name { get; private set; }
        public double Damage { get; private set; }

        public AWeapon(WeaponType type, string name, double damage)
        {
            Type = type;
            Name = name;
            Damage = damage;
        }
    }
}
